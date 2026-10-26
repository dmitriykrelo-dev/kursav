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
            this.tabLocations.SuspendLayout();
            this.tabStatuses.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCategories);
            this.tabControl1.Controls.Add(this.tabLocations);
            this.tabControl1.Controls.Add(this.tabStatuses);
            this.tabControl1.Controls.Add(this.tabEmployees);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 406);
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
            this.tabCategories.Location = new System.Drawing.Point(4, 25);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Text = "Категории";
            // 
            // dgvCategories
            // 
            this.dgvCategories.Location = new System.Drawing.Point(10, 10);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(500, 220);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(10, 243);
            this.lblCategoryName.Text = "Наименование*:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(120, 240);
            this.txtCategoryName.Size = new System.Drawing.Size(390, 24);
            // 
            // lblCategoryDesc
            // 
            this.lblCategoryDesc.AutoSize = true;
            this.lblCategoryDesc.Location = new System.Drawing.Point(10, 273);
            this.lblCategoryDesc.Text = "Описание:";
            // 
            // txtCategoryDesc
            // 
            this.txtCategoryDesc.Location = new System.Drawing.Point(120, 270);
            this.txtCategoryDesc.Size = new System.Drawing.Size(390, 24);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(120, 305);
            this.btnAddCategory.Size = new System.Drawing.Size(180, 32);
            this.btnAddCategory.Text = "Добавить";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(310, 305);
            this.btnDeleteCategory.Size = new System.Drawing.Size(180, 32);
            this.btnDeleteCategory.Text = "Удалить";
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
            this.tabLocations.Location = new System.Drawing.Point(4, 25);
            this.tabLocations.Name = "tabLocations";
            this.tabLocations.Text = "Места размещения";
            // 
            // dgvLocations
            // 
            this.dgvLocations.Location = new System.Drawing.Point(10, 10);
            this.dgvLocations.Name = "dgvLocations";
            this.dgvLocations.Size = new System.Drawing.Size(500, 220);
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(10, 243);
            this.lblLocationName.Text = "Наименование*:";
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(120, 240);
            this.txtLocationName.Size = new System.Drawing.Size(390, 24);
            // 
            // lblLocationDesc
            // 
            this.lblLocationDesc.AutoSize = true;
            this.lblLocationDesc.Location = new System.Drawing.Point(10, 273);
            this.lblLocationDesc.Text = "Описание:";
            // 
            // txtLocationDesc
            // 
            this.txtLocationDesc.Location = new System.Drawing.Point(120, 270);
            this.txtLocationDesc.Size = new System.Drawing.Size(390, 24);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(120, 305);
            this.btnAddLocation.Size = new System.Drawing.Size(180, 32);
            this.btnAddLocation.Text = "Добавить";
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.Location = new System.Drawing.Point(310, 305);
            this.btnDeleteLocation.Size = new System.Drawing.Size(180, 32);
            this.btnDeleteLocation.Text = "Удалить";
            // 
            // tabStatuses
            // 
            this.tabStatuses.Controls.Add(this.btnDeleteStatus);
            this.tabStatuses.Controls.Add(this.btnAddStatus);
            this.tabStatuses.Controls.Add(this.txtStatusName);
            this.tabStatuses.Controls.Add(this.lblStatusName);
            this.tabStatuses.Controls.Add(this.dgvStatuses);
            this.tabStatuses.Location = new System.Drawing.Point(4, 25);
            this.tabStatuses.Name = "tabStatuses";
            this.tabStatuses.Text = "Статусы";
            // 
            // dgvStatuses
            // 
            this.dgvStatuses.Location = new System.Drawing.Point(10, 10);
            this.dgvStatuses.Name = "dgvStatuses";
            this.dgvStatuses.Size = new System.Drawing.Size(500, 220);
            // 
            // lblStatusName
            // 
            this.lblStatusName.AutoSize = true;
            this.lblStatusName.Location = new System.Drawing.Point(10, 243);
            this.lblStatusName.Text = "Наименование*:";
            // 
            // txtStatusName
            // 
            this.txtStatusName.Location = new System.Drawing.Point(120, 240);
            this.txtStatusName.Size = new System.Drawing.Size(390, 24);
            // 
            // btnAddStatus
            // 
            this.btnAddStatus.Location = new System.Drawing.Point(120, 275);
            this.btnAddStatus.Size = new System.Drawing.Size(180, 32);
            this.btnAddStatus.Text = "Добавить";
            // 
            // btnDeleteStatus
            // 
            this.btnDeleteStatus.Location = new System.Drawing.Point(310, 275);
            this.btnDeleteStatus.Size = new System.Drawing.Size(180, 32);
            this.btnDeleteStatus.Text = "Удалить";
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
            this.tabEmployees.Location = new System.Drawing.Point(4, 25);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Text = "Сотрудники";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.Location = new System.Drawing.Point(10, 10);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(500, 220);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(10, 243);
            this.lblEmployeeName.Text = "ФИО*:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(120, 240);
            this.txtEmployeeName.Size = new System.Drawing.Size(390, 24);
            // 
            // lblEmployeePosition
            // 
            this.lblEmployeePosition.AutoSize = true;
            this.lblEmployeePosition.Location = new System.Drawing.Point(10, 273);
            this.lblEmployeePosition.Text = "Должность:";
            // 
            // txtEmployeePosition
            // 
            this.txtEmployeePosition.Location = new System.Drawing.Point(120, 270);
            this.txtEmployeePosition.Size = new System.Drawing.Size(180, 24);
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.Location = new System.Drawing.Point(310, 273);
            this.lblEmployeePhone.Text = "Телефон:";
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Location = new System.Drawing.Point(380, 270);
            this.txtEmployeePhone.Size = new System.Drawing.Size(130, 24);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(120, 305);
            this.btnAddEmployee.Size = new System.Drawing.Size(180, 32);
            this.btnAddEmployee.Text = "Добавить";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(310, 305);
            this.btnDeleteEmployee.Size = new System.Drawing.Size(180, 32);
            this.btnDeleteEmployee.Text = "Удалить";
            // 
            // ReferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.tabLocations.ResumeLayout(false);
            this.tabLocations.PerformLayout();
            this.tabStatuses.ResumeLayout(false);
            this.tabStatuses.PerformLayout();
            this.tabEmployees.ResumeLayout(false);
            this.tabEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}