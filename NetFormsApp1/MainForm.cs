using System;
using System.Windows.Forms;
using ComputerClubEquipment.Data;
using NetFormsApp1.Data;

namespace NetFormsApp1
{
    public partial class MainForm : Form
    {
        private EquipmentRepository _repository;

        public MainForm()
        {
            InitializeComponent();
            DatabaseHelper.InitializeDatabase();
            _repository = new EquipmentRepository();
            LoadEquipmentData();
        }

        private void LoadEquipmentData()
        {
            try
            {
                var data = _repository.GetAll();
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма добавления будет реализована на следующем шаге!", "Инфо");
        }
    }
}