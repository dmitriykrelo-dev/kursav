using Microsoft.Data.Sqlite;
using NetFormsApp1.Models;

namespace NetFormsApp1.Data
{
    public class UserRepository
    {
        public User? TryLogin(string login, string password)
        {
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();

            using var command = new SqliteCommand(
                "SELECT user_id, login, full_name, role FROM users WHERE login = @login AND password_hash = @hash;",
                connection);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@hash", DatabaseHelper.HashPassword(password));

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    UserId = reader.GetInt32(0),
                    Login = reader.GetString(1),
                    FullName = reader.GetString(2),
                    Role = reader.GetString(3)
                };
            }
            return null;
        }
    }
}