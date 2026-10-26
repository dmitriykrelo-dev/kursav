namespace NetFormsApp1
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, сгенерированный дизайнером форм Windows

        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.DataGridView dgvReport;

        private void InitializeComponent()
        {
            this.lblReportType = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(20, 23);
            this.lblReportType.Text = "Тип отчёта:";
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Items.AddRange(new object[] { "Полный реестр оборудования", "История перемещений", "Журнал обслуживаний" });
            this.cmbReportType.Location = new System.Drawing.Point(110, 20);
            this.cmbReportType.Size = new System.Drawing.Size(250, 24);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(380, 18);
            this.btnGenerate.Size = new System.Drawing.Size(140, 28);
            this.btnGenerate.Text = "Сформировать";
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Location = new System.Drawing.Point(530, 18);
            this.btnExportCsv.Size = new System.Drawing.Size(140, 28);
            this.btnExportCsv.Text = "Экспорт в CSV";
            // 
            // dgvReport
            // 
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.Location = new System.Drawing.Point(20, 60);
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(740, 370);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbReportType);
            this.Controls.Add(this.lblReportType);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Формирование отчётов";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}