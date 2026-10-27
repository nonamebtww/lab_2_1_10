using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Task1;

namespace Task1WinForms {
  // Поля ввода личных данных сотрудника.
  // Используется на странице задания 1 и на форме регистрации.
  public partial class PersonalDataBox : UserControl {
    public PersonalDataBox() {
      InitializeComponent();

      // Справочники отображаются в виде выпадающих списков.
      boxPosition.Items.AddRange(Employee.Positions);
      boxFaculty.Items.AddRange(Employee.Faculties);
      boxGender.Items.AddRange(Employee.Genders);

      pickerBirthDate.Value = DateTime.Today.AddYears(-30);
      pickerBirthDate.MaxDate = DateTime.Today;
    }

    // Присваивает введённые значения свойствам сотрудника.
    // Возвращает список ошибок, найденных свойствами.
    public List<string> Fill(Employee employee) {
      List<string> errors = new List<string>();

      TrySet(() => employee.FullName = boxFullName.Text, errors);
      TrySet(() => employee.Position = (string)boxPosition.SelectedItem, errors);
      TrySet(() => employee.Faculty = (string)boxFaculty.SelectedItem, errors);
      TrySet(() => employee.Gender = (string)boxGender.SelectedItem, errors);
      TrySet(() => employee.BirthDate = pickerBirthDate.Value, errors);
      TrySet(() => employee.Email = boxEmail.Text, errors);
      TrySet(() => employee.Phone = boxPhone.Text, errors);

      return errors;
    }

    public void Clear() {
      boxFullName.Clear();
      boxPosition.SelectedIndex = -1;
      boxFaculty.SelectedIndex = -1;
      boxGender.SelectedIndex = -1;
      pickerBirthDate.Value = DateTime.Today.AddYears(-30);
      boxEmail.Clear();
      boxPhone.Clear();
    }

    // Выполняет присваивание свойству в блоке try-catch.
    // Сообщение исключения добавляется в список ошибок.
    public static void TrySet(Action setter, List<string> errors) {
      try {
        setter();
      }
      catch (ArgumentException ex) {
        errors.Add(ex.Message);
      }
    }
  }
}
