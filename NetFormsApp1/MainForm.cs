using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NetFormsApp1.Data;
using NetFormsApp1.Models;

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

            txtSearch.TextChanged += TxtSearch_TextChanged;
            btnAddEquipment.Click += btnAddEquipment_Click;
            btnEditEquipment.Click += btnEditEquipment_Click;
            btnMoveEquipment.Click += btnMoveEquipment_Click;
            btnMaintenance.Click += btnMaintenance_Click;

            if (_currentUser != null)
            {
                string role = _currentUser.Role == "admin" ? "администратор" : "оператор";
                this.Text = $"Оборудование клуба — {_currentUser.FullName} ({role})";
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

        // Фильтрация по тексту из поля поиска
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
    }
}