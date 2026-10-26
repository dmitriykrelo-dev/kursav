using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using NetFormsApp1.Data;
using NetFormsApp1.Models;

namespace NetFormsApp1
{
    public partial class MaintenanceForm : Form
    {
        private readonly EquipmentRepository _eqRepo = new EquipmentRepository();
        private readonly MaintenanceRepository _repo = new MaintenanceRepository();
        private readonly Equipment _equipment;

        public MaintenanceForm(Equipment equipment)
        {
            InitializeComponent();
            _equipment = equipment;

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            chkNextDate.CheckedChanged += (s, e) => dtpNextDate.Enabled = chkNextDate.Checked;
        }

        private void MaintenanceForm_Load(object? sender, EventArgs e)
        {
            lblEquipmentValue.Text = $"{_equipment.InventoryNumber} — {_equipment.Name}";

            cmbEmployee.DataSource = _eqRepo.GetEmployees();
            cmbStatus.DataSource = _eqRepo.GetStatuses();

            cmbType.SelectedIndex = 0;
            SelectStatusById(_equipment.StatusId);   
            dtpDate.Value = DateTime.Now;
            cmbType.SelectedIndexChanged += CmbType_SelectedIndexChanged;
        }

        private void SelectStatusById(int id)
        {
            var items = (List<ReferenceItem>)cmbStatus.DataSource;
            var item = items.FirstOrDefault(x => x.Id == id);
            if (item != null) cmbStatus.SelectedItem = item;
        }

        private void SelectStatusByName(string name)
        {
            var items = (List<ReferenceItem>)cmbStatus.DataSource;
            var item = items.FirstOrDefault(x => x.Name == name);
            if (item != null) cmbStatus.SelectedItem = item;
        }

        // Авто-подбор статуса по типу работ (удобство для пользователя)
        private void CmbType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (cmbType.SelectedItem?.ToString())
            {
                case "Ремонт": SelectStatusByName("В ремонте"); break;
                case "Профилактика": SelectStatusByName("На обслуживании"); break;
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (cmbEmployee.SelectedItem == null)
            {
                MessageBox.Show("Выберите ответственного сотрудника!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Выберите статус оборудования!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal cost = 0m;
            string costText = txtCost.Text.Trim().Replace(',', '.');
            if (!string.IsNullOrWhiteSpace(costText) &&
                !decimal.TryParse(costText, NumberStyles.Number, CultureInfo.InvariantCulture, out cost))
            {
                MessageBox.Show("Стоимость должна быть числом (например, 3500).", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCost.Focus();
                return;
            }

            try
            {
                _repo.RegisterMaintenance(
                    _equipment.EquipmentId,
                    ((ReferenceItem)cmbEmployee.SelectedItem).Id,
                    dtpDate.Value,
                    cmbType.SelectedItem?.ToString() ?? "",
                    txtDescription.Text.Trim(),
                    cost,
                    chkNextDate.Checked ? dtpNextDate.Value : (DateTime?)null,
                    ((ReferenceItem)cmbStatus.SelectedItem).Id);

                MessageBox.Show("Запись об обслуживании сохранена, статус оборудования обновлён!",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}