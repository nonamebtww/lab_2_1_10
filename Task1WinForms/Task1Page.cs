using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Task1;

namespace Task1WinForms {
  public partial class Task1Page : UserControl {
    public Task1Page() {
      InitializeComponent();
    }

    private void btnCreate_Click(object sender, EventArgs e) {
      Employee employee = new Employee();
      List<string> errors = personalData.Fill(employee);

      if (errors.Count > 0) {
        boxInfo.Text = string.Empty;

        MessageBox.Show(
          string.Join(Environment.NewLine, errors),
          "Ошибка",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error
        );

        return;
      }

      boxInfo.Text = employee.GetInfo();
    }

    private void btnClear_Click(object sender, EventArgs e) {
      personalData.Clear();
      boxInfo.Text = string.Empty;
    }
  }
}
