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
            this.lblEquipmentTitle.Name = "lblEquipmentTitle";
            this.lblEquipmentTitle.Size = new System.Drawing.Size(96, 16);
            this.lblEquipmentTitle.TabIndex = 13;
            this.lblEquipmentTitle.Text = "Оборудование:";
            // 
            // lblEquipmentValue
            // 
            this.lblEquipmentValue.AutoSize = true;
            this.lblEquipmentValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEquipmentValue.Location = new System.Drawing.Point(150, 20);
            this.lblEquipmentValue.Name = "lblEquipmentValue";
            this.lblEquipmentValue.Size = new System.Drawing.Size(0, 16);
            this.lblEquipmentValue.TabIndex = 12;
            // 
            // lblFromTitle
            // 
            this.lblFromTitle.AutoSize = true;
            this.lblFromTitle.Location = new System.Drawing.Point(20, 50);
            this.lblFromTitle.Name = "lblFromTitle";
            this.lblFromTitle.Size = new System.Drawing.Size(90, 16);
            this.lblFromTitle.TabIndex = 11;
            this.lblFromTitle.Text = "Текущее место:";
            // 
            // lblFromValue
            // 
            this.lblFromValue.AutoSize = true;
            this.lblFromValue.Location = new System.Drawing.Point(150, 50);
            this.lblFromValue.Name = "lblFromValue";
            this.lblFromValue.Size = new System.Drawing.Size(0, 16);
            this.lblFromValue.TabIndex = 10;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(20, 80);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(84, 16);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "Новое место*:";
            // 
            // cmbToLocation
            // 
            this.cmbToLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToLocation.Location = new System.Drawing.Point(150, 77);
            this.cmbToLocation.Name = "cmbToLocation";
            this.cmbToLocation.Size = new System.Drawing.Size(300, 23);
            this.cmbToLocation.TabIndex = 8;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(20, 110);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(97, 16);
            this.lblEmployee.TabIndex = 7;
            this.lblEmployee.Text = "Ответственный*:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.Location = new System.Drawing.Point(150, 107);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(300, 23);
            this.cmbEmployee.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 140);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(114, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Дата перемещения:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(150, 137);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(300, 23);
            this.dtpDate.TabIndex = 4;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(20, 170);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(57, 16);
            this.lblReason.TabIndex = 3;
            this.lblReason.Text = "Причина:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(150, 167);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(300, 60);
            this.txtReason.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegister.Location = new System.Drawing.Point(150, 240);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(140, 36);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Зарегистрировать";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Location = new System.Drawing.Point(300, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 36);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // MovementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
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