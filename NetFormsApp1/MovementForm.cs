using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NetFormsApp1.Data;
using NetFormsApp1.Models;

namespace NetFormsApp1
{
    public partial class MovementForm : Form
    {
        private readonly EquipmentRepository _eqRepo = new EquipmentRepository();
        private readonly MovementRepository _movRepo = new MovementRepository();
        private readonly Equipment _equipment;

        public MovementForm(Equipment equipment)
        {
            InitializeComponent();
            _equipment = equipment;
            
            btnRegister.Click += BtnRegister_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void MovementForm_Load(object? sender, EventArgs e)
        {
            lblEquipmentValue.Text = $"{_equipment.InventoryNumber} — {_equipment.Name}";
            lblFromValue.Text = _equipment.LocationName;

            cmbToLocation.DataSource = _eqRepo.GetLocations();
            cmbEmployee.DataSource = _eqRepo.GetEmployees();

            // Выделяем текущее место в списке, чтобы пользователь видел его
            var locations = (List<ReferenceItem>)cmbToLocation.DataSource;
            var currentLoc = locations.FirstOrDefault(l => l.Id == _equipment.LocationId);
            if (currentLoc != null) cmbToLocation.SelectedItem = currentLoc;

            dtpDate.Value = DateTime.Now;
        }

        private void BtnRegister_Click(object? sender, EventArgs e)
        {
            if (cmbToLocation.SelectedItem == null || cmbEmployee.SelectedItem == null)
            {
                MessageBox.Show("Выберите новое место и ответственного сотрудника!", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var toLocation = (ReferenceItem)cmbToLocation.SelectedItem;

            if (toLocation.Id == _equipment.LocationId)
            {
                MessageBox.Show("Новое место должно отличаться от текущего!", "Внимание", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _movRepo.RegisterMovement(
                    _equipment.EquipmentId,
                    _equipment.LocationId,
                    toLocation.Id,
                    ((ReferenceItem)cmbEmployee.SelectedItem).Id,
                    dtpDate.Value,
                    txtReason.Text.Trim()
                );

                MessageBox.Show("Перемещение успешно зарегистрировано!", "Успех", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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