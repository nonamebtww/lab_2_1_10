using System;
using System.IO;
using GeneralConsole;
using Task1;
using Task2;

namespace Task2Console {
public static class Ui {
  public static void Task2Ui() {
    Console.WriteLine("Регистрация нового сотрудника\n");

    Employee employee = new Employee();
    Task1Console.Ui.ReadPersonalData(employee);

    Console.WriteLine("\nДанные для авторизации");

    Helpers.ReadValid("Логин: ", value => {
      employee.Login = value;

      if (Functions.LoginExists(employee.Login)) {
        throw new ArgumentException("Такой логин уже занят!");
      }
    });

    while (true) {
      Helpers.ReadValid(
        "Пароль (не менее 8 символов, цифры, заглавные буквы, "
        + "спецсимволы, без пробелов): ",
        value => employee.Password = value,
        true
      );

      string repeat = Helpers.ReadPassword("Повторите пароль: ");

      if (employee.CheckPassword(repeat)) {
        break;
      }

      Console.WriteLine("Пароли не совпадают!");
    }

    Helpers.ReadValid(
      "Код авторизации (6 цифр, пустая строка - сгенерировать): ",
      value => {
        employee.AuthCode = string.IsNullOrWhiteSpace(value)
          ? Functions.GenerateCode()
          : value;

        if (Functions.CodeExists(employee.AuthCode)) {
          throw new ArgumentException("Такой код уже используется!");
        }
      }
    );

    string path;

    try {
      path = Functions.Register(employee);
    }
    catch (Exception ex) {
      Console.WriteLine("\nОшибка регистрации: {0}", ex.Message);
      return;
    }

    Console.WriteLine("\nСотрудник зарегистрирован.");
    Console.WriteLine("Файл сотрудника: {0}", path);
    Console.WriteLine("Код авторизации: {0}", employee.AuthCode);

    string keyPath = Helpers.ReadLine(
      "\nПуть к файлу-ключу (пустая строка - не создавать): "
    ).Trim();

    if (keyPath.Length == 0) {
      return;
    }

    try {
      Functions.SaveKeyFile(keyPath, employee.AuthCode);
      Console.WriteLine("Файл-ключ создан: {0}", Path.GetFullPath(keyPath));
    }
    catch (Exception ex) {
      Console.WriteLine("Не удалось создать файл-ключ: {0}", ex.Message);
    }
  }
}
}
