using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Task1 {
// Сотрудник вуза.
// Все поля закрыты (private), доступ к ним выполняется через свойства,
// которые проверяют присваиваемые значения и при ошибке генерируют
// ArgumentException с описанием ошибки.
public class Employee {
  #region Справочники

  public static readonly string[] Positions = {
    "Ассистент",
    "Преподаватель",
    "Старший преподаватель",
    "Доцент",
    "Профессор",
    "Заведующий кафедрой",
    "Декан",
    "Лаборант",
    "Методист"
  };

  public static readonly string[] Faculties = {
    "Факультет информационных технологий",
    "Экономический факультет",
    "Юридический факультет",
    "Инженерный факультет",
    "Гуманитарный факультет",
    "Факультет естественных наук"
  };

  public static readonly string[] Genders = {
    "Мужской",
    "Женский"
  };

  #endregion

  #region Константы

  public const string DateFormat = "dd.MM.yyyy";
  public const int MinAge = 18;
  public const int MaxAge = 100;
  public const int MinPasswordLength = 8;
  public const int CodeLength = 6;

  // Названия полей в файле сотрудника.
  public const string KeyFullName = "ФИО";
  public const string KeyPosition = "Должность";
  public const string KeyFaculty = "Факультет";
  public const string KeyGender = "Пол";
  public const string KeyBirthDate = "Дата рождения";
  public const string KeyEmail = "E-mail";
  public const string KeyPhone = "Телефон";
  public const string KeyLogin = "Логин";
  public const string KeyPasswordHash = "Хеш пароля";
  public const string KeyAuthCode = "Код авторизации";

  #endregion

  #region Поля

  // Личные данные.
  private string fullName;
  private string position;
  private string faculty;
  private string gender;
  private DateTime birthDate;
  private string email;
  private string phone;

  // Данные для авторизации.
  private string login;
  private string passwordHash;
  private string authCode;

  #endregion

  #region Свойства

  public string FullName {
    get => fullName;
    set {
      string text = NormalizeSpaces(value);

      if (text.Length == 0) {
        throw new ArgumentException("ФИО не должно быть пустым.");
      }

      string[] words = text.Split(' ');

      if (words.Length < 2 || words.Length > 3) {
        throw new ArgumentException(
          "ФИО должно состоять из 2 или 3 слов (фамилия, имя, отчество)."
        );
      }

      foreach (string word in words) {
        if (!word.All(c => char.IsLetter(c) || c == '-')
            || word.StartsWith("-")
            || word.EndsWith("-")) {
          throw new ArgumentException(
            "ФИО может содержать только буквы и дефис."
          );
        }

        if (!char.IsUpper(word[0])) {
          throw new ArgumentException(
            "Каждое слово ФИО должно начинаться с заглавной буквы."
          );
        }
      }

      fullName = text;
    }
  }

  public string Position {
    get => position;
    set => position = CheckInList(value, Positions, "должность");
  }

  public string Faculty {
    get => faculty;
    set => faculty = CheckInList(value, Faculties, "факультет");
  }

  public string Gender {
    get => gender;
    set => gender = CheckInList(value, Genders, "пол");
  }

  public DateTime BirthDate {
    get => birthDate;
    set {
      DateTime date = value.Date;

      if (date > DateTime.Today) {
        throw new ArgumentException(
          "Дата рождения не может быть в будущем."
        );
      }

      int age = GetAge(date, DateTime.Today);

      if (age < MinAge || age > MaxAge) {
        throw new ArgumentException(
          "Возраст сотрудника должен быть от " + MinAge
          + " до " + MaxAge + " лет."
        );
      }

      birthDate = date;
    }
  }

  // Возраст вычисляется по дате рождения, поэтому свойство только для чтения.
  public int Age => GetAge(birthDate, DateTime.Today);

  public string Email {
    get => email;
    set {
      string text = (value ?? string.Empty).Trim();

      if (!Regex.IsMatch(text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) {
        throw new ArgumentException(
          "E-mail должен иметь вид имя@домен.зона."
        );
      }

      email = text;
    }
  }

  // Телефон хранится в виде +7XXXXXXXXXX.
  public string Phone {
    get => phone;
    set {
      string text = (value ?? string.Empty).Trim();

      if (!text.All(c => char.IsDigit(c) || "+-() ".IndexOf(c) >= 0)) {
        throw new ArgumentException(
          "Телефон может содержать только цифры, пробелы и символы + - ( )."
        );
      }

      string digits = new string(text.Where(char.IsDigit).ToArray());

      if (digits.Length != 11 || (digits[0] != '7' && digits[0] != '8')) {
        throw new ArgumentException(
          "Телефон должен быть в формате +7XXXXXXXXXX или 8XXXXXXXXXX."
        );
      }

      phone = "+7" + digits.Substring(1);
    }
  }

  public string Login {
    get => login;
    set {
      string text = (value ?? string.Empty).Trim();

      if (!IsValidLogin(text)) {
        throw new ArgumentException(
          "Логин должен содержать от 4 до 20 символов: латинские буквы, "
          + "цифры и знак подчёркивания, и начинаться с буквы."
        );
      }

      login = text;
    }
  }

  // Пароль можно только задать. В объекте хранится не сам пароль,
  // а его хеш SHA-256, поэтому прочитать пароль нельзя.
  public string Password {
    set {
      ValidatePassword(value);
      passwordHash = HashPassword(value);
    }
  }

  public bool HasPassword => passwordHash != null;

  public string AuthCode {
    get => authCode;
    set {
      string text = (value ?? string.Empty).Trim();

      if (!IsValidCode(text)) {
        throw new ArgumentException(
          "Код авторизации должен состоять из " + CodeLength + " цифр."
        );
      }

      authCode = text;
    }
  }

  #endregion

  #region Методы

  // Проверяет, совпадает ли пароль с паролем сотрудника.
  public bool CheckPassword(string password) {
    return passwordHash != null
           && password != null
           && passwordHash == HashPassword(password);
  }

  // Возвращает название первого незаполненного поля
  // или null, если заполнены все поля.
  public string GetMissingField() {
    if (fullName == null) return KeyFullName;
    if (position == null) return KeyPosition;
    if (faculty == null) return KeyFaculty;
    if (gender == null) return KeyGender;
    if (birthDate == default(DateTime)) return KeyBirthDate;
    if (email == null) return KeyEmail;
    if (phone == null) return KeyPhone;
    if (login == null) return KeyLogin;
    if (passwordHash == null) return "Пароль";
    if (authCode == null) return KeyAuthCode;

    return null;
  }

  // Информация о сотруднике для вывода на экран.
  // Пароль и код авторизации не выводятся.
  public string GetInfo() {
    StringBuilder info = new StringBuilder();

    info.AppendLine(KeyFullName + ": " + Show(fullName));
    info.AppendLine(KeyPosition + ": " + Show(position));
    info.AppendLine(KeyFaculty + ": " + Show(faculty));
    info.AppendLine(KeyGender + ": " + Show(gender));
    info.AppendLine(
      KeyBirthDate + ": "
      + (birthDate == default(DateTime)
        ? Show(null)
        : FormatDate(birthDate) + " (возраст: " + Age + ")")
    );
    info.AppendLine(KeyEmail + ": " + Show(email));
    info.AppendLine(KeyPhone + ": " + Show(phone));
    info.Append(KeyLogin + ": " + Show(login));

    return info.ToString();
  }

  public override string ToString() {
    return fullName + " (" + position + ")";
  }

  // Данные сотрудника для записи в файл.
  public Dictionary<string, string> ToRecord() {
    return new Dictionary<string, string> {
      { KeyFullName, fullName },
      { KeyPosition, position },
      { KeyFaculty, faculty },
      { KeyGender, gender },
      { KeyBirthDate, FormatDate(birthDate) },
      { KeyEmail, email },
      { KeyPhone, phone },
      { KeyLogin, login },
      { KeyPasswordHash, passwordHash },
      { KeyAuthCode, authCode }
    };
  }

  // Создаёт сотрудника по данным, прочитанным из файла.
  // Значения проходят те же проверки, что и при регистрации.
  public static Employee FromRecord(Dictionary<string, string> record) {
    Employee employee = new Employee {
      FullName = GetValue(record, KeyFullName),
      Position = GetValue(record, KeyPosition),
      Faculty = GetValue(record, KeyFaculty),
      Gender = GetValue(record, KeyGender),
      BirthDate = ParseDate(GetValue(record, KeyBirthDate)),
      Email = GetValue(record, KeyEmail),
      Phone = GetValue(record, KeyPhone),
      Login = GetValue(record, KeyLogin),
      AuthCode = GetValue(record, KeyAuthCode)
    };

    employee.passwordHash = GetValue(record, KeyPasswordHash);

    return employee;
  }

  #endregion

  #region Статические проверки

  public static bool IsValidLogin(string value) {
    return value != null
           && Regex.IsMatch(value, @"^[A-Za-z][A-Za-z0-9_]{3,19}$");
  }

  public static bool IsValidCode(string value) {
    return value != null
           && value.Length == CodeLength
           && value.All(c => c >= '0' && c <= '9');
  }

  // Пароль: не менее 8 символов, цифры, заглавные буквы,
  // специальные символы, без пробелов.
  public static void ValidatePassword(string value) {
    if (string.IsNullOrEmpty(value)) {
      throw new ArgumentException("Пароль не должен быть пустым.");
    }

    if (value.Length < MinPasswordLength) {
      throw new ArgumentException(
        "Пароль должен содержать не менее " + MinPasswordLength + " символов."
      );
    }

    if (value.Any(char.IsWhiteSpace)) {
      throw new ArgumentException("Пароль не должен содержать пробелов.");
    }

    if (!value.Any(char.IsDigit)) {
      throw new ArgumentException(
        "Пароль должен содержать хотя бы одну цифру."
      );
    }

    if (!value.Any(char.IsUpper)) {
      throw new ArgumentException(
        "Пароль должен содержать хотя бы одну заглавную букву."
      );
    }

    if (!value.Any(c => !char.IsLetterOrDigit(c))) {
      throw new ArgumentException(
        "Пароль должен содержать хотя бы один специальный символ "
        + "(например, ! @ # $ %)."
      );
    }
  }

  public static string HashPassword(string password) {
    using (SHA256 sha = SHA256.Create()) {
      byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
      StringBuilder result = new StringBuilder();

      foreach (byte b in hash) {
        result.Append(b.ToString("x2"));
      }

      return result.ToString();
    }
  }

  public static DateTime ParseDate(string value) {
    if (!DateTime.TryParseExact(
          (value ?? string.Empty).Trim(),
          DateFormat,
          CultureInfo.InvariantCulture,
          DateTimeStyles.None,
          out DateTime date
        )) {
      throw new FormatException("Дата должна быть в формате дд.мм.гггг.");
    }

    return date;
  }

  public static string FormatDate(DateTime date) {
    return date.ToString(DateFormat, CultureInfo.InvariantCulture);
  }

  #endregion

  #region Вспомогательные методы

  private static string CheckInList(string value, string[] list, string name) {
    if (value == null || Array.IndexOf(list, value) < 0) {
      throw new ArgumentException("Выберите " + name + " из списка.");
    }

    return value;
  }

  private static int GetAge(DateTime birth, DateTime today) {
    int age = today.Year - birth.Year;

    if (birth > today.AddYears(-age)) {
      age--;
    }

    return age;
  }

  private static string NormalizeSpaces(string value) {
    return string.Join(
      " ",
      (value ?? string.Empty).Split(
        new[] { ' ', '\t' },
        StringSplitOptions.RemoveEmptyEntries
      )
    );
  }

  private static string GetValue(Dictionary<string, string> record, string key) {
    if (!record.TryGetValue(key, out string value)) {
      throw new FormatException(
        "В файле сотрудника нет поля «" + key + "»."
      );
    }

    return value;
  }

  private static string Show(string value) {
    return value ?? "не указано";
  }

  #endregion
}
}
