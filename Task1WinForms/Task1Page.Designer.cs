namespace Task1WinForms {
  partial class Task1Page {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.TableLayoutPanel body;
    private System.Windows.Forms.GroupBox groupData;
    private Task1WinForms.PersonalDataBox personalData;
    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.GroupBox groupInfo;
    private System.Windows.Forms.TextBox boxInfo;

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
      this.groupData = new System.Windows.Forms.GroupBox();
      this.personalData = new Task1WinForms.PersonalDataBox();
      this.btnCreate = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.groupInfo = new System.Windows.Forms.GroupBox();
      this.boxInfo = new System.Windows.Forms.TextBox();
      this.body.SuspendLayout();
      this.groupData.SuspendLayout();
      this.groupInfo.SuspendLayout();
      this.SuspendLayout();
      //
      // body
      //
      this.body.ColumnCount = 2;
      this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 470F));
      this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Controls.Add(this.groupData, 0, 0);
      this.body.Controls.Add(this.groupInfo, 1, 0);
      this.body.Dock = System.Windows.Forms.DockStyle.Fill;
      this.body.Location = new System.Drawing.Point(0, 0);
      this.body.Name = "body";
      this.body.RowCount = 1;
      this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.body.Size = new System.Drawing.Size(960, 440);
      this.body.TabIndex = 0;
      //
      // groupData
      //
      this.groupData.Controls.Add(this.personalData);
      this.groupData.Controls.Add(this.btnCreate);
      this.groupData.Controls.Add(this.btnClear);
      this.groupData.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupData.Name = "groupData";
      this.groupData.TabIndex = 0;
      this.groupData.TabStop = false;
      this.groupData.Text = "Данные сотрудника";
      //
      // personalData
      //
      this.personalData.Location = new System.Drawing.Point(10, 20);
      this.personalData.Name = "personalData";
      this.personalData.Size = new System.Drawing.Size(440, 212);
      this.personalData.TabIndex = 0;
      //
      // btnCreate
      //
      this.btnCreate.Location = new System.Drawing.Point(120, 245);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(160, 25);
      this.btnCreate.TabIndex = 1;
      this.btnCreate.Text = "Создать объект";
      this.btnCreate.UseVisualStyleBackColor = true;
      this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
      //
      // btnClear
      //
      this.btnClear.Location = new System.Drawing.Point(290, 245);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(150, 25);
      this.btnClear.TabIndex = 2;
      this.btnClear.Text = "Очистить";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      //
      // groupInfo
      //
      this.groupInfo.Controls.Add(this.boxInfo);
      this.groupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupInfo.Name = "groupInfo";
      this.groupInfo.Padding = new System.Windows.Forms.Padding(10);
      this.groupInfo.TabIndex = 1;
      this.groupInfo.TabStop = false;
      this.groupInfo.Text = "Объект Employee";
      //
      // boxInfo
      //
      this.boxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.boxInfo.Multiline = true;
      this.boxInfo.Name = "boxInfo";
      this.boxInfo.ReadOnly = true;
      this.boxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.boxInfo.TabIndex = 0;
      //
      // Task1Page
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.body);
      this.Name = "Task1Page";
      this.Size = new System.Drawing.Size(960, 440);
      this.body.ResumeLayout(false);
      this.groupData.ResumeLayout(false);
      this.groupInfo.ResumeLayout(false);
      this.groupInfo.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
