namespace Task3WinForms {
  partial class Task3Page {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.TableLayoutPanel body;
    private System.Windows.Forms.GroupBox groupLogin;
    private System.Windows.Forms.RadioButton radioPassword;
    private System.Windows.Forms.RadioButton radioCode;
    private System.Windows.Forms.RadioButton radioKey;
    private System.Windows.Forms.Label labelLogin;
    private System.Windows.Forms.TextBox boxLogin;
    private System.Windows.Forms.Label labelPassword;
    private System.Windows.Forms.TextBox boxPassword;
    private System.Windows.Forms.Label labelCode;
    private System.Windows.Forms.TextBox boxCode;
    private System.Windows.Forms.Label labelKey;
    private System.Windows.Forms.TextBox boxKeyPath;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.GroupBox groupResult;
    private System.Windows.Forms.TextBox boxResult;
    private System.Windows.Forms.OpenFileDialog openKeyDialog;

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
      this.groupLogin = new System.Windows.Forms.GroupBox();
      this.radioPassword = new System.Windows.Forms.RadioButton();
      this.radioCode = new System.Windows.Forms.RadioButton();
      this.radioKey = new System.Windows.Forms.RadioButton();
      this.labelLogin = new System.Windows.Forms.Label();
      this.boxLogin = new System.Windows.Forms.TextBox();
      this.labelPassword = new System.Windows.Forms.Label();
      this.boxPassword = new System.Windows.Forms.TextBox();
      this.labelCode = new System.Windows.Forms.Label();
      this.boxCode = new System.Windows.Forms.TextBox();
      this.labelKey = new System.Windows.Forms.Label();
      this.boxKeyPath = new System.Windows.Forms.TextBox();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.btnLogin = new System.Windows.Forms.Button();
      this.groupResult = new System.Windows.Forms.GroupBox();
      this.boxResult = new System.Windows.Forms.TextBox();
      this.openKeyDialog = new System.Windows.Forms.OpenFileDialog();
      this.body.SuspendLayout();
      this.groupLogin.SuspendLayout();
      this.groupResult.SuspendLayout();
      this.SuspendLayout();
      //
      // body
      //
      this.body.ColumnCount = 2;
      this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 470F));
      this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Controls.Add(this.groupLogin, 0, 0);
      this.body.Controls.Add(this.groupResult, 1, 0);
      this.body.Dock = System.Windows.Forms.DockStyle.Fill;
      this.body.Location = new System.Drawing.Point(0, 0);
      this.body.Name = "body";
      this.body.RowCount = 1;
      this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Size = new System.Drawing.Size(960, 440);
      this.body.TabIndex = 0;
      //
      // groupLogin
      //
      this.groupLogin.Controls.Add(this.radioPassword);
      this.groupLogin.Controls.Add(this.radioCode);
      this.groupLogin.Controls.Add(this.radioKey);
      this.groupLogin.Controls.Add(this.labelLogin);
      this.groupLogin.Controls.Add(this.boxLogin);
      this.groupLogin.Controls.Add(this.labelPassword);
      this.groupLogin.Controls.Add(this.boxPassword);
      this.groupLogin.Controls.Add(this.labelCode);
      this.groupLogin.Controls.Add(this.boxCode);
      this.groupLogin.Controls.Add(this.labelKey);
      this.groupLogin.Controls.Add(this.boxKeyPath);
      this.groupLogin.Controls.Add(this.btnBrowse);
      this.groupLogin.Controls.Add(this.btnLogin);
      this.groupLogin.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupLogin.Name = "groupLogin";
      this.groupLogin.TabIndex = 0;
      this.groupLogin.TabStop = false;
      this.groupLogin.Text = "Авторизация сотрудника";
      //
      // radioPassword
      //
      this.radioPassword.AutoSize = true;
      this.radioPassword.Checked = true;
      this.radioPassword.Location = new System.Drawing.Point(15, 25);
      this.radioPassword.Name = "radioPassword";
      this.radioPassword.TabIndex = 0;
      this.radioPassword.TabStop = true;
      this.radioPassword.Text = "Логин и пароль";
      this.radioPassword.UseVisualStyleBackColor = true;
      this.radioPassword.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
      //
      // radioCode
      //
      this.radioCode.AutoSize = true;
      this.radioCode.Location = new System.Drawing.Point(160, 25);
      this.radioCode.Name = "radioCode";
      this.radioCode.TabIndex = 1;
      this.radioCode.Text = "Код авторизации";
      this.radioCode.UseVisualStyleBackColor = true;
      this.radioCode.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
      //
      // radioKey
      //
      this.radioKey.AutoSize = true;
      this.radioKey.Location = new System.Drawing.Point(310, 25);
      this.radioKey.Name = "radioKey";
      this.radioKey.TabIndex = 2;
      this.radioKey.Text = "Файл-ключ";
      this.radioKey.UseVisualStyleBackColor = true;
      this.radioKey.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
      //
      // labelLogin
      //
      this.labelLogin.AutoSize = true;
      this.labelLogin.Location = new System.Drawing.Point(15, 68);
      this.labelLogin.Name = "labelLogin";
      this.labelLogin.TabIndex = 3;
      this.labelLogin.Text = "Логин:";
      //
      // boxLogin
      //
      this.boxLogin.Location = new System.Drawing.Point(130, 65);
      this.boxLogin.Name = "boxLogin";
      this.boxLogin.Size = new System.Drawing.Size(200, 20);
      this.boxLogin.TabIndex = 4;
      //
      // labelPassword
      //
      this.labelPassword.AutoSize = true;
      this.labelPassword.Location = new System.Drawing.Point(15, 98);
      this.labelPassword.Name = "labelPassword";
      this.labelPassword.TabIndex = 5;
      this.labelPassword.Text = "Пароль:";
      //
      // boxPassword
      //
      this.boxPassword.Location = new System.Drawing.Point(130, 95);
      this.boxPassword.Name = "boxPassword";
      this.boxPassword.Size = new System.Drawing.Size(200, 20);
      this.boxPassword.TabIndex = 6;
      this.boxPassword.UseSystemPasswordChar = true;
      //
      // labelCode
      //
      this.labelCode.AutoSize = true;
      this.labelCode.Location = new System.Drawing.Point(15, 138);
      this.labelCode.Name = "labelCode";
      this.labelCode.TabIndex = 7;
      this.labelCode.Text = "Код авторизации:";
      //
      // boxCode
      //
      this.boxCode.Location = new System.Drawing.Point(130, 135);
      this.boxCode.MaxLength = 6;
      this.boxCode.Name = "boxCode";
      this.boxCode.Size = new System.Drawing.Size(100, 20);
      this.boxCode.TabIndex = 8;
      //
      // labelKey
      //
      this.labelKey.AutoSize = true;
      this.labelKey.Location = new System.Drawing.Point(15, 178);
      this.labelKey.Name = "labelKey";
      this.labelKey.TabIndex = 9;
      this.labelKey.Text = "Файл-ключ:";
      //
      // boxKeyPath
      //
      this.boxKeyPath.Location = new System.Drawing.Point(130, 175);
      this.boxKeyPath.Name = "boxKeyPath";
      this.boxKeyPath.Size = new System.Drawing.Size(220, 20);
      this.boxKeyPath.TabIndex = 10;
      //
      // btnBrowse
      //
      this.btnBrowse.Location = new System.Drawing.Point(360, 173);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(90, 25);
      this.btnBrowse.TabIndex = 11;
      this.btnBrowse.Text = "Обзор...";
      this.btnBrowse.UseVisualStyleBackColor = true;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      //
      // btnLogin
      //
      this.btnLogin.Location = new System.Drawing.Point(130, 220);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(160, 25);
      this.btnLogin.TabIndex = 12;
      this.btnLogin.Text = "Войти";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      //
      // groupResult
      //
      this.groupResult.Controls.Add(this.boxResult);
      this.groupResult.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupResult.Name = "groupResult";
      this.groupResult.Padding = new System.Windows.Forms.Padding(10);
      this.groupResult.TabIndex = 1;
      this.groupResult.TabStop = false;
      this.groupResult.Text = "Результат авторизации";
      //
      // boxResult
      //
      this.boxResult.Dock = System.Windows.Forms.DockStyle.Fill;
      this.boxResult.Multiline = true;
      this.boxResult.Name = "boxResult";
      this.boxResult.ReadOnly = true;
      this.boxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.boxResult.TabIndex = 0;
      this.boxResult.Text = "Пользователь не авторизован.";
      //
      // openKeyDialog
      //
      this.openKeyDialog.Filter = "Файл-ключ (*.key)|*.key|Все файлы (*.*)|*.*";
      this.openKeyDialog.Title = "Выбор файла-ключа";
      //
      // Task3Page
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.body);
      this.Name = "Task3Page";
      this.Size = new System.Drawing.Size(960, 440);
      this.body.ResumeLayout(false);
      this.groupLogin.ResumeLayout(false);
      this.groupLogin.PerformLayout();
      this.groupResult.ResumeLayout(false);
      this.groupResult.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
