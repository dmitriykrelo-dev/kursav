using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using NetFormsApp1.Data;

namespace NetFormsApp1
{
    public partial class ReferencesForm : Form
    {
        private readonly ReferenceRepository _repo = new ReferenceRepository();

        public ReferencesForm()
        {
            InitializeComponent();

            btnAddCategory.Click += btnAddCategory_Click;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            btnAddLocation.Click += btnAddLocation_Click;
            btnDeleteLocation.Click += btnDeleteLocation_Click;
            btnAddStatus.Click += btnAddStatus_Click;
            btnDeleteStatus.Click += btnDeleteStatus_Click;
            btnAddEmployee.Click += btnAddEmployee_Click;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
        }

        private void ReferencesForm_Load(object? sender, EventArgs e)
        {
            foreach (DataGridView grid in new[] { dgvCategories, dgvLocations, dgvStatuses, dgvEmployees })
            {
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.MultiSelect = false;
                grid.ReadOnly = true;
                grid.AllowUserToAddRows = false;
            }
            RefreshAll();
        }

        private void RefreshAll()
        {
            RefreshCategories();
            RefreshLocations();
            RefreshStatuses();
            RefreshEmployees();
        }

        private void RefreshCategories()
        {
            dgvCategories.DataSource = _repo.GetCategories();
            SetHeaders(dgvCategories, ("Name", "Наименование"), ("Description", "Описание"));
        }

        private void RefreshLocations()
        {
            dgvLocations.DataSource = _repo.GetLocations();
            SetHeaders(dgvLocations, ("Name", "Наименование"), ("Description", "Описание"));
        }

        private void RefreshStatuses()
        {
            dgvStatuses.DataSource = _repo.GetStatuses();
            SetHeaders(dgvStatuses, ("Name", "Статус"));
        }

        private void RefreshEmployees()
        {
            dgvEmployees.DataSource = _repo.GetEmployees();
            SetHeaders(dgvEmployees, ("FullName", "ФИО"), ("Position", "Должность"), ("Phone", "Телефон"));
        }

        private static void SetHeaders(DataGridView grid, params (string prop, string header)[] headers)
        {
            var idCol = grid.Columns["Id"];
            if (idCol != null) idCol.Visible = false;
            foreach (var (prop, header) in headers)
            {
                var col = grid.Columns[prop];
                if (col != null) col.HeaderText = header;
            }
        }

        private int? GetSelectedId(DataGridView grid)
        {
            if (grid.CurrentRow == null || grid.CurrentRow.Cells["Id"]?.Value == null ||
                grid.CurrentRow.Cells["Id"].Value == DBNull.Value)
                return null;
            return Convert.ToInt32(grid.CurrentRow.Cells["Id"].Value);
        }

        private bool RequireName(TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                MessageBox.Show("Заполните поле наименования (ФИО)!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        // Универсальный запуск операции с обработкой ошибок (в т.ч. защита от удаления используемых)
        private bool Run(Action action, string successMessage)
        {
            try
            {
                action();
                MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (ReferenceInUseException ex)
            {
                MessageBox.Show(ex.Message, "Запрет удаления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
            {
                MessageBox.Show("Операция отклонена базой данных: запись с таким именем уже существует " +
                                "или запись используется в других таблицах.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ===== Категории =====
        private void btnAddCategory_Click(object? sender, EventArgs e)
        {
            if (!RequireName(txtCategoryName)) return;
            if (Run(() => _repo.AddCategory(txtCategoryName.Text.Trim(), txtCategoryDesc.Text.Trim()), "Категория добавлена."))
            { txtCategoryName.Clear(); txtCategoryDesc.Clear(); }
            RefreshCategories();
        }

        private void btnDeleteCategory_Click(object? sender, EventArgs e)
        {
            int? id = GetSelectedId(dgvCategories);
            if (id == null) { MessageBox.Show("Выберите строку в списке.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (MessageBox.Show("Удалить выбранную категорию?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (Run(() => _repo.DeleteCategory(id.Value), "Категория удалена.")) RefreshCategories();
        }

        // ===== Места размещения =====
        private void btnAddLocation_Click(object? sender, EventArgs e)
        {
            if (!RequireName(txtLocationName)) return;
            if (Run(() => _repo.AddLocation(txtLocationName.Text.Trim(), txtLocationDesc.Text.Trim()), "Место добавлено."))
            { txtLocationName.Clear(); txtLocationDesc.Clear(); }
            RefreshLocations();
        }

        private void btnDeleteLocation_Click(object? sender, EventArgs e)
        {
            int? id = GetSelectedId(dgvLocations);
            if (id == null) { MessageBox.Show("Выберите строку в списке.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (MessageBox.Show("Удалить выбранное место размещения?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (Run(() => _repo.DeleteLocation(id.Value), "Место удалено.")) RefreshLocations();
        }

        // ===== Статусы =====
        private void btnAddStatus_Click(object? sender, EventArgs e)
        {
            if (!RequireName(txtStatusName)) return;
            if (Run(() => _repo.AddStatus(txtStatusName.Text.Trim()), "Статус добавлен."))
                txtStatusName.Clear();
            RefreshStatuses();
        }

        private void btnDeleteStatus_Click(object? sender, EventArgs e)
        {
            int? id = GetSelectedId(dgvStatuses);
            if (id == null) { MessageBox.Show("Выберите строку в списке.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (MessageBox.Show("Удалить выбранный статус?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (Run(() => _repo.DeleteStatus(id.Value), "Статус удалён.")) RefreshStatuses();
        }

        // ===== Сотрудники =====
        private void btnAddEmployee_Click(object? sender, EventArgs e)
        {
            if (!RequireName(txtEmployeeName)) return;
            if (Run(() => _repo.AddEmployee(txtEmployeeName.Text.Trim(), txtEmployeePosition.Text.Trim(), txtEmployeePhone.Text.Trim()),
                "Сотрудник добавлен."))
            { txtEmployeeName.Clear(); txtEmployeePosition.Clear(); txtEmployeePhone.Clear(); }
            RefreshEmployees();
        }

        private void btnDeleteEmployee_Click(object? sender, EventArgs e)
        {
            int? id = GetSelectedId(dgvEmployees);
            if (id == null) { MessageBox.Show("Выберите строку в списке.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (MessageBox.Show("Удалить выбранного сотрудника?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (Run(() => _repo.DeleteEmployee(id.Value), "Сотрудник удалён.")) RefreshEmployees();
        }
    }
}