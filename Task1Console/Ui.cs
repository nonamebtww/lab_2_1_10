using System;
using GeneralConsole;
using Task1;

namespace Task1Console {
public static class Ui {
  public static void Task1Ui() {
    Console.WriteLine("Создание объекта сотрудника вуза\n");

    Employee employee = new Employee();
    ReadPersonalData(employee);

    Console.WriteLine("\nОбъект сотрудника создан:");
    Console.WriteLine(employee.GetInfo());
  }

  // Ввод личных данных сотрудника. Каждое значение присваивается
  // свойству объекта; при ошибке свойство генерирует исключение
  // и ввод повторяется.
  public static void ReadPersonalData(Employee employee) {
    Helpers.ReadValid("ФИО: ", value => employee.FullName = value);

    employee.Position = Employee.Positions[
      Helpers.ReadChoice("Должность:", Employee.Positions)
    ];

    employee.Faculty = Employee.Faculties[
      Helpers.ReadChoice("Факультет:", Employee.Faculties)
    ];

    employee.Gender = Employee.Genders[
      Helpers.ReadChoice("Пол:", Employee.Genders)
    ];

    Helpers.ReadValid(
      "Дата рождения (дд.мм.гггг): ",
      value => employee.BirthDate = Employee.ParseDate(value)
    );

    Helpers.ReadValid("E-mail: ", value => employee.Email = value);

    Helpers.ReadValid(
      "Телефон (+7XXXXXXXXXX): ",
      value => employee.Phone = value
    );
  }
}
}
