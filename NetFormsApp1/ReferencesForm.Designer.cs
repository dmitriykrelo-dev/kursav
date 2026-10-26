namespace NetFormsApp1
{
    partial class ReferencesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, сгенерированный дизайнером форм Windows

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.TabPage tabLocations;
        private System.Windows.Forms.TabPage tabStatuses;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.DataGridView dgvLocations;
        private System.Windows.Forms.DataGridView dgvStatuses;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryDesc;
        private System.Windows.Forms.TextBox txtCategoryDesc;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.Label lblLocationDesc;
        private System.Windows.Forms.TextBox txtLocationDesc;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnDeleteLocation;
        private System.Windows.Forms.Label lblStatusName;
        private System.Windows.Forms.TextBox txtStatusName;
        private System.Windows.Forms.Button btnAddStatus;
        private System.Windows.Forms.Button btnDeleteStatus;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeePosition;
        private System.Windows.Forms.TextBox txtEmployeePosition;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryDesc = new System.Windows.Forms.Label();
            this.txtCategoryDesc = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.tabLocations = new System.Windows.Forms.TabPage();
            this.dgvLocations = new System.Windows.Forms.DataGridView();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.lblLocationDesc = new System.Windows.Forms.Label();
            this.txtLocationDesc = new System.Windows.Forms.TextBox();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnDeleteLocation = new System.Windows.Forms.Button();
            this.tabStatuses = new System.Windows.Forms.TabPage();
            this.dgvStatuses = new System.Windows.Forms.DataGridView();
            this.lblStatusName = new System.Windows.Forms.Label();
            this.txtStatusName = new System.Windows.Forms.TextBox();
            this.btnAddStatus = new System.Windows.Forms.Button();
            this.btnDeleteStatus = new System.Windows.Forms.Button();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeePosition = new System.Windows.Forms.Label();
            this.txtEmployeePosition = new System.Windows.Forms.TextBox();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.tabLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).BeginInit();
            this.tabStatuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatuses)).BeginInit();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCategories);
            this.tabControl1.Controls.Add(this.tabLocations);
            this.tabControl1.Controls.Add(this.tabStatuses);
            this.tabControl1.Controls.Add(this.tabEmployees);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 3;
            this.tabControl1.Size = new System.Drawing.Size(536, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCategories
            // 
            this.tabCategories.Controls.Add(this.btnDeleteCategory);
            this.tabCategories.Controls.Add(this.btnAddCategory);
            this.tabCategories.Controls.Add(this.txtCategoryDesc);
            this.tabCategories.Controls.Add(this.lblCategoryDesc);
            this.tabCategories.Controls.Add(this.txtCategoryName);
            this.tabCategories.Controls.Add(this.lblCategoryName);
            this.tabCategories.Controls.Add(this.dgvCategories);
            this.tabCategories.Location = new System.Drawing.Point(4, 24);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Size = new System.Drawing.Size(528, 378);
            this.tabCategories.TabIndex = 0;
            this.tabCategories.Text = "Категории";
            // 
            // dgvCategories
            // 
            this.dgvCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvCategories.GridColor = System.Drawing.Color.Silver;
            this.dgvCategories.Location = new System.Drawing.Point(10, 10);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(500, 220);
            this.dgvCategories.TabIndex = 6;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(10, 243);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(96, 16);
            this.lblCategoryName.TabIndex = 5;
            this.lblCategoryName.Text = "Наименование*:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(120, 240);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(390, 23);
            this.txtCategoryName.TabIndex = 4;
            // 
            // lblCategoryDesc
            // 
            this.lblCategoryDesc.AutoSize = true;
            this.lblCategoryDesc.Location = new System.Drawing.Point(10, 273);
            this.lblCategoryDesc.Name = "lblCategoryDesc";
            this.lblCategoryDesc.Size = new System.Drawing.Size(63, 16);
            this.lblCategoryDesc.TabIndex = 3;
            this.lblCategoryDesc.Text = "Описание:";
            // 
            // txtCategoryDesc
            // 
            this.txtCategoryDesc.Location = new System.Drawing.Point(120, 270);
            this.txtCategoryDesc.Name = "txtCategoryDesc";
            this.txtCategoryDesc.Size = new System.Drawing.Size(390, 23);
            this.txtCategoryDesc.TabIndex = 2;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddCategory.Location = new System.Drawing.Point(120, 305);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(180, 32);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Добавить";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteCategory.Location = new System.Drawing.Point(310, 305);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(180, 32);
            this.btnDeleteCategory.TabIndex = 0;
            this.btnDeleteCategory.Text = "Удалить";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // tabLocations
            // 
            this.tabLocations.Controls.Add(this.btnDeleteLocation);
            this.tabLocations.Controls.Add(this.btnAddLocation);
            this.tabLocations.Controls.Add(this.txtLocationDesc);
            this.tabLocations.Controls.Add(this.lblLocationDesc);
            this.tabLocations.Controls.Add(this.txtLocationName);
            this.tabLocations.Controls.Add(this.lblLocationName);
            this.tabLocations.Controls.Add(this.dgvLocations);
            this.tabLocations.Location = new System.Drawing.Point(4, 24);
            this.tabLocations.Name = "tabLocations";
            this.tabLocations.Size = new System.Drawing.Size(528, 378);
            this.tabLocations.TabIndex = 1;
            this.tabLocations.Text = "Места размещения";
            // 
            // dgvLocations
            // 
            this.dgvLocations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvLocations.GridColor = System.Drawing.Color.Silver;
            this.dgvLocations.Location = new System.Drawing.Point(10, 10);
            this.dgvLocations.Name = "dgvLocations";
            this.dgvLocations.Size = new System.Drawing.Size(500, 220);
            this.dgvLocations.TabIndex = 6;
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(10, 243);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(96, 16);
            this.lblLocationName.TabIndex = 5;
            this.lblLocationName.Text = "Наименование*:";
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(120, 240);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(390, 23);
            this.txtLocationName.TabIndex = 4;
            // 
            // lblLocationDesc
            // 
            this.lblLocationDesc.AutoSize = true;
            this.lblLocationDesc.Location = new System.Drawing.Point(10, 273);
            this.lblLocationDesc.Name = "lblLocationDesc";
            this.lblLocationDesc.Size = new System.Drawing.Size(63, 16);
            this.lblLocationDesc.TabIndex = 3;
            this.lblLocationDesc.Text = "Описание:";
            // 
            // txtLocationDesc
            // 
            this.txtLocationDesc.Location = new System.Drawing.Point(120, 270);
            this.txtLocationDesc.Name = "txtLocationDesc";
            this.txtLocationDesc.Size = new System.Drawing.Size(390, 23);
            this.txtLocationDesc.TabIndex = 2;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddLocation.Location = new System.Drawing.Point(120, 305);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(180, 32);
            this.btnAddLocation.TabIndex = 1;
            this.btnAddLocation.Text = "Добавить";
            this.btnAddLocation.UseVisualStyleBackColor = false;
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteLocation.Location = new System.Drawing.Point(310, 305);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(180, 32);
            this.btnDeleteLocation.TabIndex = 0;
            this.btnDeleteLocation.Text = "Удалить";
            this.btnDeleteLocation.UseVisualStyleBackColor = false;
            // 
            // tabStatuses
            // 
            this.tabStatuses.Controls.Add(this.btnDeleteStatus);
            this.tabStatuses.Controls.Add(this.btnAddStatus);
            this.tabStatuses.Controls.Add(this.txtStatusName);
            this.tabStatuses.Controls.Add(this.lblStatusName);
            this.tabStatuses.Controls.Add(this.dgvStatuses);
            this.tabStatuses.Location = new System.Drawing.Point(4, 24);
            this.tabStatuses.Name = "tabStatuses";
            this.tabStatuses.Size = new System.Drawing.Size(528, 378);
            this.tabStatuses.TabIndex = 2;
            this.tabStatuses.Text = "Статусы";
            // 
            // dgvStatuses
            // 
            this.dgvStatuses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvStatuses.GridColor = System.Drawing.Color.Silver;
            this.dgvStatuses.Location = new System.Drawing.Point(10, 10);
            this.dgvStatuses.Name = "dgvStatuses";
            this.dgvStatuses.Size = new System.Drawing.Size(500, 220);
            this.dgvStatuses.TabIndex = 4;
            // 
            // lblStatusName
            // 
            this.lblStatusName.AutoSize = true;
            this.lblStatusName.Location = new System.Drawing.Point(10, 243);
            this.lblStatusName.Name = "lblStatusName";
            this.lblStatusName.Size = new System.Drawing.Size(96, 16);
            this.lblStatusName.TabIndex = 3;
            this.lblStatusName.Text = "Наименование*:";
            // 
            // txtStatusName
            // 
            this.txtStatusName.Location = new System.Drawing.Point(120, 240);
            this.txtStatusName.Name = "txtStatusName";
            this.txtStatusName.Size = new System.Drawing.Size(390, 23);
            this.txtStatusName.TabIndex = 2;
            // 
            // btnAddStatus
            // 
            this.btnAddStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddStatus.Location = new System.Drawing.Point(120, 275);
            this.btnAddStatus.Name = "btnAddStatus";
            this.btnAddStatus.Size = new System.Drawing.Size(180, 32);
            this.btnAddStatus.TabIndex = 1;
            this.btnAddStatus.Text = "Добавить";
            this.btnAddStatus.UseVisualStyleBackColor = false;
            // 
            // btnDeleteStatus
            // 
            this.btnDeleteStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteStatus.Location = new System.Drawing.Point(310, 275);
            this.btnDeleteStatus.Name = "btnDeleteStatus";
            this.btnDeleteStatus.Size = new System.Drawing.Size(180, 32);
            this.btnDeleteStatus.TabIndex = 0;
            this.btnDeleteStatus.Text = "Удалить";
            this.btnDeleteStatus.UseVisualStyleBackColor = false;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.btnDeleteEmployee);
            this.tabEmployees.Controls.Add(this.btnAddEmployee);
            this.tabEmployees.Controls.Add(this.txtEmployeePhone);
            this.tabEmployees.Controls.Add(this.lblEmployeePhone);
            this.tabEmployees.Controls.Add(this.txtEmployeePosition);
            this.tabEmployees.Controls.Add(this.lblEmployeePosition);
            this.tabEmployees.Controls.Add(this.txtEmployeeName);
            this.tabEmployees.Controls.Add(this.lblEmployeeName);
            this.tabEmployees.Controls.Add(this.dgvEmployees);
            this.tabEmployees.Location = new System.Drawing.Point(4, 24);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Size = new System.Drawing.Size(528, 378);
            this.tabEmployees.TabIndex = 3;
            this.tabEmployees.Text = "Сотрудники";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvEmployees.GridColor = System.Drawing.Color.Silver;
            this.dgvEmployees.Location = new System.Drawing.Point(10, 10);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(500, 220);
            this.dgvEmployees.TabIndex = 8;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(10, 243);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(40, 16);
            this.lblEmployeeName.TabIndex = 7;
            this.lblEmployeeName.Text = "ФИО*:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(120, 240);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(390, 23);
            this.txtEmployeeName.TabIndex = 6;
            // 
            // lblEmployeePosition
            // 
            this.lblEmployeePosition.AutoSize = true;
            this.lblEmployeePosition.Location = new System.Drawing.Point(10, 273);
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.Size = new System.Drawing.Size(69, 16);
            this.lblEmployeePosition.TabIndex = 5;
            this.lblEmployeePosition.Text = "Должность:";
            // 
            // txtEmployeePosition
            // 
            this.txtEmployeePosition.Location = new System.Drawing.Point(120, 270);
            this.txtEmployeePosition.Name = "txtEmployeePosition";
            this.txtEmployeePosition.Size = new System.Drawing.Size(180, 23);
            this.txtEmployeePosition.TabIndex = 4;
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.Location = new System.Drawing.Point(310, 273);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(55, 16);
            this.lblEmployeePhone.TabIndex = 3;
            this.lblEmployeePhone.Text = "Телефон:";
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Location = new System.Drawing.Point(380, 270);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(130, 23);
            this.txtEmployeePhone.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddEmployee.Location = new System.Drawing.Point(120, 305);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(180, 32);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Добавить";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(310, 305);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(180, 32);
            this.btnDeleteEmployee.TabIndex = 0;
            this.btnDeleteEmployee.Text = "Удалить";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            // 
            // ReferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(560, 430);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReferencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочники";
            this.Load += new System.EventHandler(this.ReferencesForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCategories.ResumeLayout(false);
            this.tabCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.tabLocations.ResumeLayout(false);
            this.tabLocations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).EndInit();
            this.tabStatuses.ResumeLayout(false);
            this.tabStatuses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatuses)).EndInit();
            this.tabEmployees.ResumeLayout(false);
            this.tabEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}