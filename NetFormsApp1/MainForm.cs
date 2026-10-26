using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NetFormsApp1.Data;
using NetFormsApp1.Models;

namespace NetFormsApp1
{
    public partial class MainForm : Form
    {
        private EquipmentRepository _repository;
        private List<Equipment> _equipmentList = new List<Equipment>();

        public MainForm()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            DatabaseHelper.InitializeDatabase();
            _repository = new EquipmentRepository();
            LoadEquipmentData();
        }

        private void LoadEquipmentData()
        {
            try
            {
                _equipmentList = _repository.GetAll();
                dataGridView1.DataSource = _equipmentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            // Ищем по ID из ячейки — надёжно даже если таблицу отсортировали кликом по заголовку
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

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            using (var form = new EquipmentEditForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    LoadEquipmentData();
            }
        }

        private void btnEditEquipment_Click(object sender, EventArgs e)
        {
            Equipment? selected = GetSelectedEquipment();

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
    }
}