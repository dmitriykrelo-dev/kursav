using System;
using System.Windows.Forms;
using NetFormsApp1.Data;
using NetFormsApp1.Models;

namespace NetFormsApp1
{
    public partial class LoginForm : Form
    {
        public User? LoggedUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            AcceptButton = btnLogin;          // Enter = кнопка «Войти»
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Введите логин!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите пароль!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                var repository = new UserRepository();
                var user = repository.TryLogin(txtLogin.Text.Trim(), txtPassword.Text);

                if (user == null)
                {
                    MessageBox.Show("Неверный логин или пароль!", "Доступ запрещён",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                LoggedUser = user;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обращения к базе данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}