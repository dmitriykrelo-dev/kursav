namespace NetFormsApp1
{
    partial class MaintenanceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, сгенерированный дизайнером форм Windows

        private System.Windows.Forms.Label lblEquipmentTitle;
        private System.Windows.Forms.Label lblEquipmentValue;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.CheckBox chkNextDate;
        private System.Windows.Forms.DateTimePicker dtpNextDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            this.lblEquipmentTitle = new System.Windows.Forms.Label();
            this.lblEquipmentValue = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.chkNextDate = new System.Windows.Forms.CheckBox();
            this.dtpNextDate = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEquipmentTitle
            // 
            this.lblEquipmentTitle.AutoSize = true;
            this.lblEquipmentTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEquipmentTitle.Location = new System.Drawing.Point(20, 20);
            this.lblEquipmentTitle.Text = "Оборудование:";
            // 
            // lblEquipmentValue
            // 
            this.lblEquipmentValue.AutoSize = true;
            this.lblEquipmentValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEquipmentValue.Location = new System.Drawing.Point(150, 20);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(20, 50);
            this.lblEmployee.Text = "Ответственный*:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.Location = new System.Drawing.Point(150, 47);
            this.cmbEmployee.Size = new System.Drawing.Size(300, 24);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 80);
            this.lblDate.Text = "Дата работ:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(150, 77);
            this.dtpDate.Size = new System.Drawing.Size(300, 24);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 110);
            this.lblType.Text = "Тип работ*:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Items.AddRange(new object[] { "Профилактика", "Ремонт", "Диагностика", "Модернизация" });
            this.cmbType.Location = new System.Drawing.Point(150, 107);
            this.cmbType.Size = new System.Drawing.Size(300, 24);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 140);
            this.lblStatus.Text = "Статус после работ:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(150, 137);
            this.cmbStatus.Size = new System.Drawing.Size(300, 24);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(20, 170);
            this.lblCost.Text = "Стоимость, руб.:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(150, 167);
            this.txtCost.Size = new System.Drawing.Size(300, 24);
            // 
            // chkNextDate
            // 
            this.chkNextDate.AutoSize = true;
            this.chkNextDate.Location = new System.Drawing.Point(150, 200);
            this.chkNextDate.Text = "Назначить дату следующего обслуживания";
            // 
            // dtpNextDate
            // 
            this.dtpNextDate.Enabled = false;
            this.dtpNextDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNextDate.Location = new System.Drawing.Point(150, 228);
            this.dtpNextDate.Size = new System.Drawing.Size(300, 24);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 262);
            this.lblDescription.Text = "Описание:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 259);
            this.txtDescription.Multiline = true;
            this.txtDescription.Size = new System.Drawing.Size(300, 70);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 340);
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 340);
            this.btnCancel.Size = new System.Drawing.Size(140, 36);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 395);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dtpNextDate);
            this.Controls.Add(this.chkNextDate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblEquipmentValue);
            this.Controls.Add(this.lblEquipmentTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Техническое обслуживание";
            this.Load += new System.EventHandler(this.MaintenanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}