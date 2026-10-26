using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using NetFormsApp1.Data;

namespace NetFormsApp1
{
    public partial class ReportForm : Form
    {
        private readonly ReportRepository _repo = new ReportRepository();

        public ReportForm()
        {
            InitializeComponent();
            cmbReportType.SelectedIndex = 0;
            btnGenerate.Click += BtnGenerate_Click;
            btnExportCsv.Click += BtnExportCsv_Click;
        }

        private void BtnGenerate_Click(object? sender, EventArgs e)
        {
            try
            {
                switch (cmbReportType.SelectedIndex)
                {
                    case 0: dgvReport.DataSource = _repo.GetFullRegistry(); break;
                    case 1: dgvReport.DataSource = _repo.GetMovements(); break;
                    case 2: dgvReport.DataSource = _repo.GetMaintenance(); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка формирования отчёта: {ex.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExportCsv_Click(object? sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("Сначала сформируйте отчёт!", "Внимание", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = $"report_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Используем UTF-8 с BOM, чтобы Excel корректно открывал кириллицу
                        using (var writer = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                        {
                            // Заголовки
                            for (int i = 0; i < dgvReport.Columns.Count; i++)
                            {
                                writer.Write(dgvReport.Columns[i].HeaderText);
                                if (i < dgvReport.Columns.Count - 1) writer.Write(";");
                            }
                            writer.WriteLine();

                            // Строки
                            foreach (DataGridViewRow row in dgvReport.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                                    {
                                        writer.Write(row.Cells[i].Value?.ToString()?.Replace(";", ","));
                                        if (i < dgvReport.Columns.Count - 1) writer.Write(";");
                                    }
                                    writer.WriteLine();
                                }
                            }
                        }
                        MessageBox.Show($"Отчёт успешно сохранён:\n{sfd.FileName}", "Успех", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}