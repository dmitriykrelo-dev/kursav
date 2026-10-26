namespace NetFormsApp1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, сгенерированный дизайнером форм Windows

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnEditEquipment;
        private System.Windows.Forms.Button btnMoveEquipment;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnEditEquipment = new System.Windows.Forms.Button();
            this.btnMoveEquipment = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 16);
            this.lblSearch.Text = "Поиск:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(80, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 24);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(400, 15);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(120, 30);
            this.btnAddEquipment.Text = "Добавить";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            // 
            // btnEditEquipment
            // 
            this.btnEditEquipment.Location = new System.Drawing.Point(530, 15);
            this.btnEditEquipment.Name = "btnEditEquipment";
            this.btnEditEquipment.Size = new System.Drawing.Size(120, 30);
            this.btnEditEquipment.Text = "Изменить";
            this.btnEditEquipment.UseVisualStyleBackColor = true;
            // 
            // btnMoveEquipment
            // 
            this.btnMoveEquipment.Location = new System.Drawing.Point(660, 15);
            this.btnMoveEquipment.Name = "btnMoveEquipment";
            this.btnMoveEquipment.Size = new System.Drawing.Size(120, 30);
            this.btnMoveEquipment.Text = "Переместить";
            this.btnMoveEquipment.UseVisualStyleBackColor = true;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(790, 15);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(140, 30);
            this.btnMaintenance.Text = "Обслуживание";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(940, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 540);
            this.Controls.Add(this.btnEditEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.btnMoveEquipment);
            this.Controls.Add(this.btnMaintenance);
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