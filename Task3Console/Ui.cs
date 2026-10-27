using System;
using GeneralConsole;
using Task1;
using Task4;

namespace Task3Console {
public static class Ui {
  private static readonly string[] Methods = {
    "Логин и пароль",
    "Код авторизации",
    "Файл-ключ"
  };

  public static void Task3Ui() {
    Console.WriteLine("Авторизация сотрудника\n");

    int method = Helpers.ReadChoice("Способ авторизации:", Methods);

    Employee user;
    string failMessage;

    try {
      switch (method) {
        case 0:
          string login = Helpers.ReadString("Логин: ");
          string password = Helpers.ReadPassword("Пароль: ");
          user = Functions.ByPassword(login, password);
          failMessage = "Неверный логин или пароль.";
          break;
        case 1:
          string code = Helpers.ReadString("Код авторизации: ");
          user = Functions.ByCode(code);
          failMessage = "Сотрудник с таким кодом авторизации не найден.";
          break;
        default:
          string keyPath = Helpers.ReadString("Путь к файлу-ключу: ");
          user = Functions.ByKey(keyPath);
          failMessage = "Файл-ключ недействителен.";
          break;
      }
    }
    catch (Exception ex) {
      Console.WriteLine("\nОшибка авторизации: {0}", ex.Message);
      return;
    }

    if (user == null) {
      Console.WriteLine("\nАвторизация не выполнена. {0}", failMessage);
      return;
    }

    Console.WriteLine(
      "\nАвторизация выполнена успешно. Добро пожаловать, {0}!\n",
      user.FullName
    );
    Console.WriteLine(user.GetInfo());
  }
}
}
