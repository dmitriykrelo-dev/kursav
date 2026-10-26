using System;
using System.Windows.Forms;
using NetFormsApp1.Data;

namespace NetFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Если у тебя в шаблоне были строки EnableVisualStyles / SetCompatibleTextRenderingDefault — оставь их вместо этой:
            ApplicationConfiguration.Initialize();

            DatabaseHelper.InitializeDatabase();

            using (var loginForm = new LoginForm())
            {
                // Не вошёл (закрыл окно или отменил) — программа просто завершается
                if (loginForm.ShowDialog() != DialogResult.OK || loginForm.LoggedUser == null)
                    return;

                Application.Run(new MainForm(loginForm.LoggedUser));
            }
        }
    }
}