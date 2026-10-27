using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Task1;

namespace Task2 {
// Регистрация нового сотрудника.
public static class Functions {
  private static readonly Random Random = new Random();

  public static bool LoginExists(string login) {
    return File.Exists(Storage.GetFilePath(login));
  }

  public static bool CodeExists(string code) {
    foreach (string file in Storage.GetFiles()) {
      Dictionary<string, string> record = Storage.Read(file);

      if (record.TryGetValue(Employee.KeyAuthCode, out string value)
          && value == code) {
        return true;
      }
    }

    return false;
  }

  // Создаёт случайный код авторизации, который ещё не используется.
  public static string GenerateCode() {
    string code;

    do {
      code = Random.Next(0, 1000000).ToString("D" + Employee.CodeLength);
    } while (CodeExists(code));

    return code;
  }

  // Сохраняет сотрудника в новый файл в папке employees.
  // Возвращает путь к созданному файлу.
  public static string Register(Employee employee) {
    string missing = employee.GetMissingField();

    if (missing != null) {
      throw new InvalidOperationException(
        "Не заполнено поле «" + missing + "»."
      );
    }

    if (LoginExists(employee.Login)) {
      throw new InvalidOperationException(
        "Сотрудник с логином «" + employee.Login + "» уже зарегистрирован."
      );
    }

    if (CodeExists(employee.AuthCode)) {
      throw new InvalidOperationException(
        "Такой код авторизации уже используется. Укажите другой код."
      );
    }

    string path = Storage.GetFilePath(employee.Login);
    Storage.Write(path, employee.ToRecord());

    return path;
  }

  // Создаёт файл-ключ, содержащий код авторизации.
  public static void SaveKeyFile(string path, string code) {
    File.WriteAllText(path, code, new UTF8Encoding(false));
  }
}
}
