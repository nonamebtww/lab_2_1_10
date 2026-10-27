namespace Task2WinForms {
  partial class Task2Page {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.TableLayoutPanel body;
    private System.Windows.Forms.GroupBox groupPersonal;
    private Task1WinForms.PersonalDataBox personalData;
    private System.Windows.Forms.GroupBox groupAuth;
    private System.Windows.Forms.Label labelLogin;
    private System.Windows.Forms.TextBox boxLogin;
    private System.Windows.Forms.Label labelPassword;
    private System.Windows.Forms.TextBox boxPassword;
    private System.Windows.Forms.Label labelRepeat;
    private System.Windows.Forms.TextBox boxRepeat;
    private System.Windows.Forms.Label labelPasswordHint;
    private System.Windows.Forms.Label labelCode;
    private System.Windows.Forms.TextBox boxCode;
    private System.Windows.Forms.Button btnGenerate;
    private System.Windows.Forms.CheckBox checkKey;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.TextBox boxResult;
    private System.Windows.Forms.SaveFileDialog saveKeyDialog;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }

      base.Dispose(disposing);
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.body = new System.Windows.Forms.TableLayoutPanel();
      this.groupPersonal = new System.Windows.Forms.GroupBox();
      this.personalData = new Task1WinForms.PersonalDataBox();
      this.groupAuth = new System.Windows.Forms.GroupBox();
      this.labelLogin = new System.Windows.Forms.Label();
      this.boxLogin = new System.Windows.Forms.TextBox();
      this.labelPassword = new System.Windows.Forms.Label();
      this.boxPassword = new System.Windows.Forms.TextBox();
      this.labelRepeat = new System.Windows.Forms.Label();
      this.boxRepeat = new System.Windows.Forms.TextBox();
      this.labelPasswordHint = new System.Windows.Forms.Label();
      this.labelCode = new System.Windows.Forms.Label();
      this.boxCode = new System.Windows.Forms.TextBox();
      this.btnGenerate = new System.Windows.Forms.Button();
      this.checkKey = new System.Windows.Forms.CheckBox();
      this.btnRegister = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.boxResult = new System.Windows.Forms.TextBox();
      this.saveKeyDialog = new System.Windows.Forms.SaveFileDialog();
      this.body.SuspendLayout();
      this.groupPersonal.SuspendLayout();
      this.groupAuth.SuspendLayout();
      this.SuspendLayout();
      //
      // body
      //
      this.body.ColumnCount = 2;
      this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 470F));
      this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Controls.Add(this.groupPersonal, 0, 0);
      this.body.Controls.Add(this.groupAuth, 1, 0);
      this.body.Dock = System.Windows.Forms.DockStyle.Fill;
      this.body.Location = new System.Drawing.Point(0, 0);
      this.body.Name = "body";
      this.body.RowCount = 1;
      this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Size = new System.Drawing.Size(960, 440);
      this.body.TabIndex = 0;
      //
      // groupPersonal
      //
      this.groupPersonal.Controls.Add(this.personalData);
      this.groupPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupPersonal.Name = "groupPersonal";
      this.groupPersonal.TabIndex = 0;
      this.groupPersonal.TabStop = false;
      this.groupPersonal.Text = "Личные данные";
      //
      // personalData
      //
      this.personalData.Location = new System.Drawing.Point(10, 20);
      this.personalData.Name = "personalData";
      this.personalData.Size = new System.Drawing.Size(440, 212);
      this.personalData.TabIndex = 0;
      //
      // groupAuth
      //
      this.groupAuth.Controls.Add(this.labelLogin);
      this.groupAuth.Controls.Add(this.boxLogin);
      this.groupAuth.Controls.Add(this.labelPassword);
      this.groupAuth.Controls.Add(this.boxPassword);
      this.groupAuth.Controls.Add(this.labelRepeat);
      this.groupAuth.Controls.Add(this.boxRepeat);
      this.groupAuth.Controls.Add(this.labelPasswordHint);
      this.groupAuth.Controls.Add(this.labelCode);
      this.groupAuth.Controls.Add(this.boxCode);
      this.groupAuth.Controls.Add(this.btnGenerate);
      this.groupAuth.Controls.Add(this.checkKey);
      this.groupAuth.Controls.Add(this.btnRegister);
      this.groupAuth.Controls.Add(this.btnClear);
      this.groupAuth.Controls.Add(this.boxResult);
      this.groupAuth.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupAuth.Location = new System.Drawing.Point(473, 3);
      this.groupAuth.Size = new System.Drawing.Size(484, 434);
      this.groupAuth.Name = "groupAuth";
      this.groupAuth.TabIndex = 1;
      this.groupAuth.TabStop = false;
      this.groupAuth.Text = "Данные для авторизации";
      //
      // labelLogin
      //
      this.labelLogin.AutoSize = true;
      this.labelLogin.Location = new System.Drawing.Point(15, 28);
      this.labelLogin.Name = "labelLogin";
      this.labelLogin.TabIndex = 0;
      this.labelLogin.Text = "Логин:";
      //
      // boxLogin
      //
      this.boxLogin.Location = new System.Drawing.Point(130, 25);
      this.boxLogin.Name = "boxLogin";
      this.boxLogin.Size = new System.Drawing.Size(200, 20);
      this.boxLogin.TabIndex = 1;
      //
      // labelPassword
      //
      this.labelPassword.AutoSize = true;
      this.labelPassword.Location = new System.Drawing.Point(15, 58);
      this.labelPassword.Name = "labelPassword";
      this.labelPassword.TabIndex = 2;
      this.labelPassword.Text = "Пароль:";
      //
      // boxPassword
      //
      this.boxPassword.Location = new System.Drawing.Point(130, 55);
      this.boxPassword.Name = "boxPassword";
      this.boxPassword.Size = new System.Drawing.Size(200, 20);
      this.boxPassword.TabIndex = 3;
      this.boxPassword.UseSystemPasswordChar = true;
      //
      // labelRepeat
      //
      this.labelRepeat.AutoSize = true;
      this.labelRepeat.Location = new System.Drawing.Point(15, 88);
      this.labelRepeat.Name = "labelRepeat";
      this.labelRepeat.TabIndex = 4;
      this.labelRepeat.Text = "Повтор пароля:";
      //
      // boxRepeat
      //
      this.boxRepeat.Location = new System.Drawing.Point(130, 85);
      this.boxRepeat.Name = "boxRepeat";
      this.boxRepeat.Size = new System.Drawing.Size(200, 20);
      this.boxRepeat.TabIndex = 5;
      this.boxRepeat.UseSystemPasswordChar = true;
      //
      // labelPasswordHint
      //
      this.labelPasswordHint.ForeColor = System.Drawing.SystemColors.GrayText;
      this.labelPasswordHint.Location = new System.Drawing.Point(130, 108);
      this.labelPasswordHint.Name = "labelPasswordHint";
      this.labelPasswordHint.Size = new System.Drawing.Size(330, 28);
      this.labelPasswordHint.TabIndex = 6;
      this.labelPasswordHint.Text = "Не менее 8 символов, цифры, заглавные буквы и специальные символы, без пробелов.";
      //
      // labelCode
      //
      this.labelCode.AutoSize = true;
      this.labelCode.Location = new System.Drawing.Point(15, 143);
      this.labelCode.Name = "labelCode";
      this.labelCode.TabIndex = 7;
      this.labelCode.Text = "Код авторизации:";
      //
      // boxCode
      //
      this.boxCode.Location = new System.Drawing.Point(130, 140);
      this.boxCode.MaxLength = 6;
      this.boxCode.Name = "boxCode";
      this.boxCode.Size = new System.Drawing.Size(100, 20);
      this.boxCode.TabIndex = 8;
      //
      // btnGenerate
      //
      this.btnGenerate.Location = new System.Drawing.Point(240, 138);
      this.btnGenerate.Name = "btnGenerate";
      this.btnGenerate.Size = new System.Drawing.Size(120, 25);
      this.btnGenerate.TabIndex = 9;
      this.btnGenerate.Text = "Сгенерировать";
      this.btnGenerate.UseVisualStyleBackColor = true;
      this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
      //
      // checkKey
      //
      this.checkKey.AutoSize = true;
      this.checkKey.Checked = true;
      this.checkKey.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkKey.Location = new System.Drawing.Point(130, 172);
      this.checkKey.Name = "checkKey";
      this.checkKey.TabIndex = 10;
      this.checkKey.Text = "Сохранить файл-ключ";
      this.checkKey.UseVisualStyleBackColor = true;
      //
      // btnRegister
      //
      this.btnRegister.Location = new System.Drawing.Point(130, 200);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(160, 25);
      this.btnRegister.TabIndex = 11;
      this.btnRegister.Text = "Зарегистрировать";
      this.btnRegister.UseVisualStyleBackColor = true;
      this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
      //
      // btnClear
      //
      this.btnClear.Location = new System.Drawing.Point(300, 200);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(120, 25);
      this.btnClear.TabIndex = 12;
      this.btnClear.Text = "Очистить";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      //
      // boxResult
      //
      this.boxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.boxResult.Location = new System.Drawing.Point(15, 235);
      this.boxResult.Multiline = true;
      this.boxResult.Name = "boxResult";
      this.boxResult.ReadOnly = true;
      this.boxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.boxResult.Size = new System.Drawing.Size(455, 185);
      this.boxResult.TabIndex = 13;
      //
      // saveKeyDialog
      //
      this.saveKeyDialog.DefaultExt = "key";
      this.saveKeyDialog.Filter = "Файл-ключ (*.key)|*.key|Все файлы (*.*)|*.*";
      this.saveKeyDialog.Title = "Сохранение файла-ключа";
      //
      // Task2Page
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.body);
      this.Name = "Task2Page";
      this.Size = new System.Drawing.Size(960, 440);
      this.body.ResumeLayout(false);
      this.groupPersonal.ResumeLayout(false);
      this.groupAuth.ResumeLayout(false);
      this.groupAuth.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
