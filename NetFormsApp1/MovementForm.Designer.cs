namespace NetFormsApp1
{
    partial class MovementForm
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
        private System.Windows.Forms.Label lblFromTitle;
        private System.Windows.Forms.Label lblFromValue;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cmbToLocation;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            this.lblEquipmentTitle = new System.Windows.Forms.Label();
            this.lblEquipmentValue = new System.Windows.Forms.Label();
            this.lblFromTitle = new System.Windows.Forms.Label();
            this.lblFromValue = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.cmbToLocation = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
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
            this.lblEquipmentValue.Location = new System.Drawing.Point(150, 20);
            this.lblEquipmentValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            // 
            // lblFromTitle
            // 
            this.lblFromTitle.AutoSize = true;
            this.lblFromTitle.Location = new System.Drawing.Point(20, 50);
            this.lblFromTitle.Text = "Текущее место:";
            // 
            // lblFromValue
            // 
            this.lblFromValue.AutoSize = true;
            this.lblFromValue.Location = new System.Drawing.Point(150, 50);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(20, 80);
            this.lblTo.Text = "Новое место*:";
            // 
            // cmbToLocation
            // 
            this.cmbToLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToLocation.Location = new System.Drawing.Point(150, 77);
            this.cmbToLocation.Size = new System.Drawing.Size(300, 24);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(20, 110);
            this.lblEmployee.Text = "Ответственный*:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.Location = new System.Drawing.Point(150, 107);
            this.cmbEmployee.Size = new System.Drawing.Size(300, 24);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 140);
            this.lblDate.Text = "Дата перемещения:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(150, 137);
            this.dtpDate.Size = new System.Drawing.Size(300, 24);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(20, 170);
            this.lblReason.Text = "Причина:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(150, 167);
            this.txtReason.Multiline = true;
            this.txtReason.Size = new System.Drawing.Size(300, 60);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(150, 240);
            this.btnRegister.Size = new System.Drawing.Size(140, 36);
            this.btnRegister.Text = "Зарегистрировать";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 240);
            this.btnCancel.Size = new System.Drawing.Size(140, 36);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // MovementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cmbToLocation);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFromValue);
            this.Controls.Add(this.lblFromTitle);
            this.Controls.Add(this.lblEquipmentValue);
            this.Controls.Add(this.lblEquipmentTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрация перемещения";
            this.Load += new System.EventHandler(this.MovementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}