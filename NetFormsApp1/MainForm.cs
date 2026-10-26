using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.IO; 
using NetFormsApp1.Data;
using NetFormsApp1.Models;
using Microsoft.Data.Sqlite;

namespace NetFormsApp1
{
    public partial class MainForm : Form
    {
        private EquipmentRepository _repository;
        private List<Equipment> _equipmentList = new List<Equipment>();
        private User? _currentUser;

        public MainForm(User? currentUser = null)
        {
            _currentUser = currentUser;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            DatabaseHelper.InitializeDatabase();
            _repository = new EquipmentRepository();
            LoadEquipmentData();

            // Подписки на все события кнопок
            txtSearch.TextChanged += TxtSearch_TextChanged;
            btnAddEquipment.Click += btnAddEquipment_Click;
            btnEditEquipment.Click += btnEditEquipment_Click;
            btnMoveEquipment.Click += btnMoveEquipment_Click;
            btnMaintenance.Click += btnMaintenance_Click;
            btnReferences.Click += btnReferences_Click;
            btnBackup.Click += btnBackup_Click;
            btnDeleteEquipment.Click += btnDeleteEquipment_Click; 
            btnReports.Click += btnReports_Click;                 

            // ===== НОВАЯ ЛОГИКА РАЗГРАНИЧЕНИЯ ПРАВ (5 РОЛЕЙ) =====
            UserRole role = _currentUser?.Role ?? UserRole.Viewer;
            
            // Матрица доступа согласно п. 1.3 и 2.1 курсового проекта
            btnAddEquipment.Visible = role == UserRole.Admin || role == UserRole.Technician;
            btnEditEquipment.Visible = role == UserRole.Admin || role == UserRole.Technician;
            btnDeleteEquipment.Visible = role == UserRole.Admin; // Только админ
            btnMoveEquipment.Visible = role == UserRole.Admin || role == UserRole.Operator || role == UserRole.Technician;
            btnMaintenance.Visible = role == UserRole.Admin || role == UserRole.Technician;
            btnReferences.Visible = role == UserRole.Admin; // Только админ
            btnReports.Visible = role == UserRole.Admin || role == UserRole.Accountant; // Админ и Бухгалтер
            btnBackup.Visible = role == UserRole.Admin; // Только админ

            // Формируем красивый заголовок окна в зависимости от роли
            if (_currentUser != null)
            {
                string roleName = role switch
                {
                    UserRole.Admin => "Администратор",
                    UserRole.Operator => "Оператор",
                    UserRole.Technician => "Техник",
                    UserRole.Accountant => "Бухгалтер",
                    UserRole.Viewer => "Наблюдатель",
                    _ => "Пользователь"
                };
                this.Text = $"Учёт оборудования — {_currentUser.FullName} ({roleName})";
            }
        }

        private void LoadEquipmentData()
        {
            try
            {
                _equipmentList = _repository.GetAll();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilter()
        {
            string searchTerm = txtSearch.Text.Trim().ToLowerInvariant();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dataGridView1.DataSource = _equipmentList;
                return;
            }

            var filtered = _equipmentList.Where(eq =>
                (eq.InventoryNumber?.ToLowerInvariant().Contains(searchTerm) ?? false) ||
                (eq.Name?.ToLowerInvariant().Contains(searchTerm) ?? false) ||
                (eq.CategoryName?.ToLowerInvariant().Contains(searchTerm) ?? false) ||
                (eq.LocationName?.ToLowerInvariant().Contains(searchTerm) ?? false) ||
                (eq.StatusName?.ToLowerInvariant().Contains(searchTerm) ?? false) ||
                (eq.SerialNumber?.ToLowerInvariant().Contains(searchTerm) ?? false)
            ).ToList();

            dataGridView1.DataSource = filtered;
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            ApplyFilter();
        }

        private Equipment? GetSelectedEquipment()
        {
            DataGridViewRow? row = null;

            if (dataGridView1.SelectedRows.Count > 0)
                row = dataGridView1.SelectedRows[0];
            else if (dataGridView1.CurrentRow != null)
                row = dataGridView1.CurrentRow;
            else if (dataGridView1.CurrentCell != null)
                row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

            if (row == null) return null;

            if (dataGridView1.Columns.Contains("EquipmentId") &&
                row.Cells["EquipmentId"].Value != null &&
                row.Cells["EquipmentId"].Value != DBNull.Value)
            {
                int id = Convert.ToInt32(row.Cells["EquipmentId"].Value);
                return _equipmentList.Find(x => x.EquipmentId == id);
            }

            if (row.Index >= 0 && row.Index < _equipmentList.Count)
                return _equipmentList[row.Index];

            return null;
        }

        private void btnAddEquipment_Click(object? sender, EventArgs e)
        {
            using (var form = new EquipmentEditForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    LoadEquipmentData();
            }
        }

        private void btnEditEquipment_Click(object? sender, EventArgs e)
        {
            var selected = GetSelectedEquipment();
            if (selected == null)
            {
                MessageBox.Show("Сначала выберите строку оборудования в таблице.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var form = new EquipmentEditForm(selected))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    LoadEquipmentData();
            }
        }

        private void btnMoveEquipment_Click(object? sender, EventArgs e)
        {
            var selected = GetSelectedEquipment();
            if (selected == null)
            {
                MessageBox.Show("Сначала выберите строку оборудования в таблице.", "Внимание", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var form = new MovementForm(selected))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    LoadEquipmentData();
            }
        }

        private void btnMaintenance_Click(object? sender, EventArgs e)
        {
            var selected = GetSelectedEquipment();
            if (selected == null)
            {
                MessageBox.Show("Сначала выберите строку оборудования в таблице.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var form = new MaintenanceForm(selected))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    LoadEquipmentData();
            }
        }

        private void btnReferences_Click(object? sender, EventArgs e)
        {
            using (var form = new ReferencesForm())
            {
                form.ShowDialog(this);
            }
            LoadEquipmentData();
        }
        
        private void btnBackup_Click(object? sender, EventArgs e)
        {
            try
            {
                string backupDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "backups");
                Directory.CreateDirectory(backupDir);
                string dest = Path.Combine(backupDir, $"equipment_backup_{DateTime.Now:yyyyMMdd_HHmmss}.db");
                File.Copy(DatabaseHelper.DbPath, dest, true);
                MessageBox.Show($"Резервная копия создана:\n{dest}", "Резервное копирование",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось создать резервную копию: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteEquipment_Click(object? sender, EventArgs e)
        {
            var selected = GetSelectedEquipment();
            if (selected == null)
            {
                MessageBox.Show("Сначала выберите строку оборудования в таблице.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show($"Вы уверены, что хотите удалить '{selected.Name}' (Инв. {selected.InventoryNumber})?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _repository.Delete(selected.EquipmentId);
                    LoadEquipmentData();
                }
                catch (SqliteException ex) when (ex.SqliteErrorCode == 19) 
                {
                    MessageBox.Show("Невозможно удалить оборудование: по нему уже зарегистрированы перемещения или обслуживания.\nСначала удалите связанные записи или измените статус на 'Списано'.", 
                                    "Запрет удаления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReports_Click(object? sender, EventArgs e)
        {
            using (var form = new ReportForm())
            {
                form.ShowDialog(this);
            }
        }
    }
}