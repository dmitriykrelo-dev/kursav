namespace NetFormsApp1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, сгенерированный дизайнером форм Windows

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnEditEquipment;
        private System.Windows.Forms.Button btnMoveEquipment;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnReferences;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnEditEquipment = new System.Windows.Forms.Button();
            this.btnMoveEquipment = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnReferences = new System.Windows.Forms.Button();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(20, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 425);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddEquipment.Location = new System.Drawing.Point(350, 15);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(110, 30);
            this.btnAddEquipment.TabIndex = 5;
            this.btnAddEquipment.Text = "Добавить";
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            // 
            // btnEditEquipment
            // 
            this.btnEditEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditEquipment.Location = new System.Drawing.Point(470, 15);
            this.btnEditEquipment.Name = "btnEditEquipment";
            this.btnEditEquipment.Size = new System.Drawing.Size(110, 30);
            this.btnEditEquipment.TabIndex = 4;
            this.btnEditEquipment.Text = "Изменить";
            this.btnEditEquipment.UseVisualStyleBackColor = false;
            // 
            // btnMoveEquipment
            // 
            this.btnMoveEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMoveEquipment.Location = new System.Drawing.Point(590, 15);
            this.btnMoveEquipment.Name = "btnMoveEquipment";
            this.btnMoveEquipment.Size = new System.Drawing.Size(120, 30);
            this.btnMoveEquipment.TabIndex = 3;
            this.btnMoveEquipment.Text = "Переместить";
            this.btnMoveEquipment.UseVisualStyleBackColor = false;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMaintenance.Location = new System.Drawing.Point(720, 15);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(130, 30);
            this.btnMaintenance.TabIndex = 2;
            this.btnMaintenance.Text = "Обслуживание";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            // 
            // btnReferences
            // 
            this.btnReferences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReferences.Location = new System.Drawing.Point(860, 15);
            this.btnReferences.Name = "btnReferences";
            this.btnReferences.Size = new System.Drawing.Size(130, 30);
            this.btnReferences.TabIndex = 1;
            this.btnReferences.Text = "Справочники";
            this.btnReferences.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteEquipment.Location = new System.Drawing.Point(350, 50);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(110, 30);
            this.btnDeleteEquipment.TabIndex = 6;
            this.btnDeleteEquipment.Text = "Удалить";
            this.btnDeleteEquipment.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReports.Location = new System.Drawing.Point(470, 50);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(110, 30);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Отчёты";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBackup.Location = new System.Drawing.Point(1000, 15);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(150, 30);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Резервная копия";
            this.btnBackup.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(80, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 23);
            this.txtSearch.TabIndex = 8;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(42, 16);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Поиск:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1170, 540);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnReferences);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnMoveEquipment);
            this.Controls.Add(this.btnEditEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт оборудования";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}