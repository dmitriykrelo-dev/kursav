using System;
using System.Globalization;
using System.Windows.Forms;
using NetFormsApp1.Data;
using NetFormsApp1.Models;

namespace NetFormsApp1
{
    public partial class EquipmentEditForm : Form
    {
        private readonly EquipmentRepository _repository = new EquipmentRepository();
        private Equipment? _editing; // null = режим добавления

        public EquipmentEditForm()
        {
            InitializeComponent();
            Text = "Добавление оборудования";
            Load += EquipmentEditForm_Load;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        public EquipmentEditForm(Equipment equipment) : this()
        {
            _editing = equipment;
            Text = "Редактирование оборудования";
        }

        private void EquipmentEditForm_Load(object? sender, EventArgs e)
        {
            cmbCategory.DataSource = _repository.GetCategories();
            cmbLocation.DataSource = _repository.GetLocations();
            cmbStatus.DataSource = _repository.GetStatuses();

            if (_editing != null)
            {
                txtInventoryNumber.Text = _editing.InventoryNumber ?? string.Empty;
                txtSerialNumber.Text = _editing.SerialNumber ?? string.Empty;
                txtName.Text = _editing.Name ?? string.Empty;
                txtPrice.Text = _editing.Price.ToString(CultureInfo.InvariantCulture);
                txtNotes.Text = _editing.Notes ?? string.Empty;
            
                if (DateTime.TryParse(_editing.PurchaseDate, out var date))
                    dtpPurchaseDate.Value = date;
            
                SelectById(cmbCategory, _editing.CategoryId);
                SelectById(cmbLocation, _editing.LocationId);
                SelectById(cmbStatus, _editing.StatusId);
            }
        }

        private void SelectById(ComboBox combo, int id)
        {
            for (int i = 0; i < combo.Items.Count; i++)
                if (((ReferenceItem)combo.Items[i]!).Id == id) { combo.SelectedIndex = i; return; }
            if (combo.Items.Count > 0) combo.SelectedIndex = 0;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Проверки обязательных полей (тест-сценарий из раздела 4)
            if (string.IsNullOrWhiteSpace(txtInventoryNumber.Text))
            {
                MessageBox.Show("Заполните инвентарный номер!", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInventoryNumber.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Заполните наименование!", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            decimal price = 0m;
            string priceText = txtPrice.Text.Trim().Replace(',', '.');
            if (!string.IsNullOrWhiteSpace(priceText) &&
                !decimal.TryParse(priceText, NumberStyles.Number, CultureInfo.InvariantCulture, out price))
            {
                MessageBox.Show("Стоимость должна быть числом (например, 45000 или 45000.50).",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            var equipment = new Equipment
            {
                InventoryNumber = txtInventoryNumber.Text.Trim(),
                SerialNumber = txtSerialNumber.Text.Trim(),
                Name = txtName.Text.Trim(),
                CategoryId = ((ReferenceItem)cmbCategory.SelectedItem!).Id,
                LocationId = ((ReferenceItem)cmbLocation.SelectedItem!).Id,
                StatusId = ((ReferenceItem)cmbStatus.SelectedItem!).Id,
                PurchaseDate = dtpPurchaseDate.Value.ToString("yyyy-MM-dd"),
                Price = price,
                Notes = txtNotes.Text.Trim()
            };

            try
            {
                if (_editing == null)
                    _repository.Add(equipment);
                else
                {
                    equipment.EquipmentId = _editing.EquipmentId;
                    _repository.Update(equipment);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                // Сюда попадёт, например, попытка сохранить дубликат инв. номера (UNIQUE)
                MessageBox.Show($"Не удалось сохранить данные: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}