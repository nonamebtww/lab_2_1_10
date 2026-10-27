using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Task1;
using Task1WinForms;
using FunctionsTask2 = Task2.Functions;

namespace Task2WinForms {
  public partial class Task2Page : UserControl {
    public Task2Page() {
      InitializeComponent();
    }

    private static void ShowError(string message) {
      MessageBox.Show(
        message,
        "Ошибка",
        MessageBoxButtons.OK,
        MessageBoxIcon.Error
      );
    }

    private void btnGenerate_Click(object sender, EventArgs e) {
      try {
        boxCode.Text = FunctionsTask2.GenerateCode();
      }
      catch (Exception ex) {
        ShowError(ex.Message);
      }
    }

    private void btnRegister_Click(object sender, EventArgs e) {
      Employee employee = new Employee();

      // Проверка вводимых значений выполняется свойствами класса Employee.
      List<string> errors = personalData.Fill(employee);

      PersonalDataBox.TrySet(() => employee.Login = boxLogin.Text, errors);
      PersonalDataBox.TrySet(() => employee.Password = boxPassword.Text, errors);

      if (boxPassword.Text != boxRepeat.Text) {
        errors.Add("Пароли не совпадают.");
      }

      PersonalDataBox.TrySet(() => employee.AuthCode = boxCode.Text, errors);

      if (errors.Count > 0) {
        ShowError(string.Join(Environment.NewLine, errors));
        return;
      }

      string path;

      try {
        path = FunctionsTask2.Register(employee);
      }
      catch (Exception ex) {
        ShowError(ex.Message);
        return;
      }

      string result =
        "Сотрудник зарегистрирован." + Environment.NewLine
        + "Файл сотрудника: " + path + Environment.NewLine
        + "Код авторизации: " + employee.AuthCode + Environment.NewLine;

      if (checkKey.Checked) {
        saveKeyDialog.FileName = employee.Login + ".key";

        if (saveKeyDialog.ShowDialog() == DialogResult.OK) {
          try {
            FunctionsTask2.SaveKeyFile(saveKeyDialog.FileName, employee.AuthCode);
            result += "Файл-ключ: " + saveKeyDialog.FileName + Environment.NewLine;
          }
          catch (Exception ex) {
            ShowError("Не удалось создать файл-ключ: " + ex.Message);
          }
        }
      }

      boxResult.Text = result + Environment.NewLine + employee.GetInfo();

      MessageBox.Show(
        "Сотрудник " + employee.FullName + " зарегистрирован.",
        "Готово",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
      );
    }

    private void btnClear_Click(object sender, EventArgs e) {
      personalData.Clear();
      boxLogin.Clear();
      boxPassword.Clear();
      boxRepeat.Clear();
      boxCode.Clear();
      checkKey.Checked = true;
      boxResult.Clear();
    }
  }
}
