namespace Task1WinForms {
  partial class PersonalDataBox {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label labelFullName;
    private System.Windows.Forms.TextBox boxFullName;
    private System.Windows.Forms.Label labelPosition;
    private System.Windows.Forms.ComboBox boxPosition;
    private System.Windows.Forms.Label labelFaculty;
    private System.Windows.Forms.ComboBox boxFaculty;
    private System.Windows.Forms.Label labelGender;
    private System.Windows.Forms.ComboBox boxGender;
    private System.Windows.Forms.Label labelBirthDate;
    private System.Windows.Forms.DateTimePicker pickerBirthDate;
    private System.Windows.Forms.Label labelEmail;
    private System.Windows.Forms.TextBox boxEmail;
    private System.Windows.Forms.Label labelPhone;
    private System.Windows.Forms.TextBox boxPhone;

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
      this.labelFullName = new System.Windows.Forms.Label();
      this.boxFullName = new System.Windows.Forms.TextBox();
      this.labelPosition = new System.Windows.Forms.Label();
      this.boxPosition = new System.Windows.Forms.ComboBox();
      this.labelFaculty = new System.Windows.Forms.Label();
      this.boxFaculty = new System.Windows.Forms.ComboBox();
      this.labelGender = new System.Windows.Forms.Label();
      this.boxGender = new System.Windows.Forms.ComboBox();
      this.labelBirthDate = new System.Windows.Forms.Label();
      this.pickerBirthDate = new System.Windows.Forms.DateTimePicker();
      this.labelEmail = new System.Windows.Forms.Label();
      this.boxEmail = new System.Windows.Forms.TextBox();
      this.labelPhone = new System.Windows.Forms.Label();
      this.boxPhone = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      //
      // labelFullName
      //
      this.labelFullName.AutoSize = true;
      this.labelFullName.Location = new System.Drawing.Point(5, 8);
      this.labelFullName.Name = "labelFullName";
      this.labelFullName.TabIndex = 0;
      this.labelFullName.Text = "ФИО:";
      //
      // boxFullName
      //
      this.boxFullName.Location = new System.Drawing.Point(110, 5);
      this.boxFullName.Name = "boxFullName";
      this.boxFullName.Size = new System.Drawing.Size(320, 20);
      this.boxFullName.TabIndex = 1;
      //
      // labelPosition
      //
      this.labelPosition.AutoSize = true;
      this.labelPosition.Location = new System.Drawing.Point(5, 38);
      this.labelPosition.Name = "labelPosition";
      this.labelPosition.TabIndex = 2;
      this.labelPosition.Text = "Должность:";
      //
      // boxPosition
      //
      this.boxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.boxPosition.Location = new System.Drawing.Point(110, 35);
      this.boxPosition.Name = "boxPosition";
      this.boxPosition.Size = new System.Drawing.Size(320, 21);
      this.boxPosition.TabIndex = 3;
      //
      // labelFaculty
      //
      this.labelFaculty.AutoSize = true;
      this.labelFaculty.Location = new System.Drawing.Point(5, 68);
      this.labelFaculty.Name = "labelFaculty";
      this.labelFaculty.TabIndex = 4;
      this.labelFaculty.Text = "Факультет:";
      //
      // boxFaculty
      //
      this.boxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.boxFaculty.Location = new System.Drawing.Point(110, 65);
      this.boxFaculty.Name = "boxFaculty";
      this.boxFaculty.Size = new System.Drawing.Size(320, 21);
      this.boxFaculty.TabIndex = 5;
      //
      // labelGender
      //
      this.labelGender.AutoSize = true;
      this.labelGender.Location = new System.Drawing.Point(5, 98);
      this.labelGender.Name = "labelGender";
      this.labelGender.TabIndex = 6;
      this.labelGender.Text = "Пол:";
      //
      // boxGender
      //
      this.boxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.boxGender.Location = new System.Drawing.Point(110, 95);
      this.boxGender.Name = "boxGender";
      this.boxGender.Size = new System.Drawing.Size(150, 21);
      this.boxGender.TabIndex = 7;
      //
      // labelBirthDate
      //
      this.labelBirthDate.AutoSize = true;
      this.labelBirthDate.Location = new System.Drawing.Point(5, 128);
      this.labelBirthDate.Name = "labelBirthDate";
      this.labelBirthDate.TabIndex = 8;
      this.labelBirthDate.Text = "Дата рождения:";
      //
      // pickerBirthDate
      //
      this.pickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.pickerBirthDate.Location = new System.Drawing.Point(110, 125);
      this.pickerBirthDate.Name = "pickerBirthDate";
      this.pickerBirthDate.Size = new System.Drawing.Size(150, 20);
      this.pickerBirthDate.TabIndex = 9;
      //
      // labelEmail
      //
      this.labelEmail.AutoSize = true;
      this.labelEmail.Location = new System.Drawing.Point(5, 158);
      this.labelEmail.Name = "labelEmail";
      this.labelEmail.TabIndex = 10;
      this.labelEmail.Text = "E-mail:";
      //
      // boxEmail
      //
      this.boxEmail.Location = new System.Drawing.Point(110, 155);
      this.boxEmail.Name = "boxEmail";
      this.boxEmail.Size = new System.Drawing.Size(320, 20);
      this.boxEmail.TabIndex = 11;
      //
      // labelPhone
      //
      this.labelPhone.AutoSize = true;
      this.labelPhone.Location = new System.Drawing.Point(5, 188);
      this.labelPhone.Name = "labelPhone";
      this.labelPhone.TabIndex = 12;
      this.labelPhone.Text = "Телефон:";
      //
      // boxPhone
      //
      this.boxPhone.Location = new System.Drawing.Point(110, 185);
      this.boxPhone.Name = "boxPhone";
      this.boxPhone.Size = new System.Drawing.Size(150, 20);
      this.boxPhone.TabIndex = 13;
      //
      // PersonalDataBox
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelFullName);
      this.Controls.Add(this.boxFullName);
      this.Controls.Add(this.labelPosition);
      this.Controls.Add(this.boxPosition);
      this.Controls.Add(this.labelFaculty);
      this.Controls.Add(this.boxFaculty);
      this.Controls.Add(this.labelGender);
      this.Controls.Add(this.boxGender);
      this.Controls.Add(this.labelBirthDate);
      this.Controls.Add(this.pickerBirthDate);
      this.Controls.Add(this.labelEmail);
      this.Controls.Add(this.boxEmail);
      this.Controls.Add(this.labelPhone);
      this.Controls.Add(this.boxPhone);
      this.Name = "PersonalDataBox";
      this.Size = new System.Drawing.Size(440, 212);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
