using System;
using GeneralConsole;

namespace AppConsole {
  internal class Program {
    private static void Main(string[] args) {
      while (true) {
        Console.Clear();

        Console.Write(
          "Задания:\n" +
          "1. Задание 1 - класс сотрудника вуза (Employee)\n" +
          "2. Задание 2 - регистрация нового сотрудника\n" +
          "3. Задания 3, 4 - авторизация сотрудника\n" +
          "0. Выход\n" +
          "Введите действие: "
        );

        switch (Console.ReadLine()) {
            case "1":
              Task1Console.Ui.Task1Ui();
              Helpers.Pause();
              break;
            case "2":
              Task2Console.Ui.Task2Ui();
              Helpers.Pause();
              break;
            case "3":
              Task3Console.Ui.Task3Ui();
              Helpers.Pause();
              break;
            case "0":
              return;
            default:
              Console.WriteLine("Введено неверное значение!");
              Helpers.Pause();
              break;
        }
      }
    }
  }
}
