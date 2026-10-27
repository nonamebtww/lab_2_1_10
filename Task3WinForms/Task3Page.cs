using System;
using System.Windows.Forms;
using Task1;
using FunctionsTask4 = Task4.Functions;

namespace Task3WinForms {
  public partial class Task3Page : UserControl {
    public Task3Page() {
      InitializeComponent();
      UpdateInputs();
    }

    // Делает доступными только поля выбранного способа авторизации.
    private void UpdateInputs() {
      boxLogin.Enabled = radioPassword.Checked;
      boxPassword.Enabled = radioPassword.Checked;
      boxCode.Enabled = radioCode.Checked;
      boxKeyPath.Enabled = radioKey.Checked;
      btnBrowse.Enabled = radioKey.Checked;
    }

    private void radio_CheckedChanged(object sender, EventArgs e) {
      UpdateInputs();
    }

    private void btnBrowse_Click(object sender, EventArgs e) {
      if (openKeyDialog.ShowDialog() == DialogResult.OK) {
        boxKeyPath.Text = openKeyDialog.FileName;
      }
    }

    private void btnLogin_Click(object sender, EventArgs e) {
      Employee user;
      string failMessage;

      try {
        if (radioPassword.Checked) {
          user = FunctionsTask4.ByPassword(boxLogin.Text, boxPassword.Text);
          failMessage = "Неверный логин или пароль.";
        }
        else if (radioCode.Checked) {
          user = FunctionsTask4.ByCode(boxCode.Text);
          failMessage = "Сотрудник с таким кодом авторизации не найден.";
        }
        else {
          user = FunctionsTask4.ByKey(boxKeyPath.Text);
          failMessage = "Файл-ключ недействителен.";
        }
      }
      catch (Exception ex) {
        boxResult.Text = "Пользователь не авторизован.";

        MessageBox.Show(
          ex.Message,
          "Ошибка авторизации",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error
        );

        return;
      }

      if (user == null) {
        boxResult.Text = "Пользователь не авторизован.";

        MessageBox.Show(
          "Авторизация не выполнена. " + failMessage,
          "Авторизация",
          MessageBoxButtons.OK,
          MessageBoxIcon.Warning
        );

        return;
      }

      boxResult.Text =
        "Авторизован пользователь:" + Environment.NewLine
        + Environment.NewLine + user.GetInfo();

      MessageBox.Show(
        "Авторизация выполнена успешно. Добро пожаловать, "
        + user.FullName + "!",
        "Авторизация",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
      );
    }
  }
}
