namespace NetFormsApp1
{
    partial class EquipmentEditForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtInventoryNumber;
        private TextBox txtSerialNumber;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private ComboBox cmbLocation;
        private ComboBox cmbStatus;
        private DateTimePicker dtpPurchaseDate;
        private TextBox txtPrice;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnCancel;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInventoryNumber = new TextBox();
            txtSerialNumber = new TextBox();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            cmbLocation = new ComboBox();
            cmbStatus = new ComboBox();
            dtpPurchaseDate = new DateTimePicker();
            txtPrice = new TextBox();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            //
            // txtInventoryNumber
            //
            txtInventoryNumber.Location = new Point(142, 18);
            txtInventoryNumber.Name = "txtInventoryNumber";
            txtInventoryNumber.Size = new Size(121, 23);
            txtInventoryNumber.TabIndex = 0;
            //
            // txtSerialNumber
            //
            txtSerialNumber.Location = new Point(142, 47);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(121, 23);
            txtSerialNumber.TabIndex = 1;
            //
            // txtName
            //
            txtName.Location = new Point(142, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 2;
            //
            // cmbCategory
            //
            cmbCategory.Location = new Point(142, 105);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 3;
            //
            // cmbLocation
            //
            cmbLocation.Location = new Point(142, 134);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(121, 23);
            cmbLocation.TabIndex = 4;
            //
            // cmbStatus
            //
            cmbStatus.Location = new Point(142, 163);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 5;
            //
            // dtpPurchaseDate
            //
            dtpPurchaseDate.Location = new Point(142, 192);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(121, 23);
            dtpPurchaseDate.TabIndex = 6;
            //
            // txtPrice
            //
            txtPrice.Location = new Point(142, 221);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 7;
            //
            // txtNotes
            //
            txtNotes.Location = new Point(142, 250);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(121, 23);
            txtNotes.TabIndex = 8;
            //
            // btnSave
            //
            btnSave.Location = new Point(165, 279);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            //
            // btnCancel
            //
            btnCancel.Location = new Point(165, 308);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "button2";
            btnCancel.UseVisualStyleBackColor = true;
            //
            // EquipmentEditForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 354);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNotes);
            Controls.Add(txtPrice);
            Controls.Add(dtpPurchaseDate);
            Controls.Add(cmbStatus);
            Controls.Add(cmbLocation);
            Controls.Add(cmbCategory);
            Controls.Add(txtName);
            Controls.Add(txtSerialNumber);
            Controls.Add(txtInventoryNumber);
            Name = "EquipmentEditForm";
            Text = "EquipmentEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
