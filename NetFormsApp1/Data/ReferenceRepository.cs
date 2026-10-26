using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using NetFormsApp1.Models;

namespace NetFormsApp1.Data
{
    public class ReferenceInUseException : Exception
    {
        public ReferenceInUseException()
            : base("Невозможно удалить: запись используется в карточках оборудования или других таблицах.") { }
    }

    public class ReferenceRepository
    {
        // ===== Просмотр =====
        public List<CategoryItem> GetCategories() => GetNameDescriptionList("categories", "category_id");
        public List<CategoryItem> GetLocations()  => GetNameDescriptionList("locations", "location_id");

        private List<CategoryItem> GetNameDescriptionList(string table, string idColumn)
        {
            var list = new List<CategoryItem>();
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            using var cmd = new SqliteCommand($"SELECT {idColumn}, name, description FROM {table} ORDER BY name;", connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new CategoryItem
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.IsDBNull(2) ? "" : reader.GetString(2)
                });
            return list;
        }

        public List<ReferenceItem> GetStatuses()
        {
            var list = new List<ReferenceItem>();
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            using var cmd = new SqliteCommand("SELECT status_id, name FROM statuses ORDER BY name;", connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new ReferenceItem { Id = reader.GetInt32(0), Name = reader.GetString(1) });
            return list;
        }

        public List<EmployeeItem> GetEmployees()
        {
            var list = new List<EmployeeItem>();
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            using var cmd = new SqliteCommand("SELECT employee_id, full_name, position, phone FROM employees ORDER BY full_name;", connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(new EmployeeItem
                {
                    Id = reader.GetInt32(0),
                    FullName = reader.GetString(1),
                    Position = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    Phone = reader.IsDBNull(3) ? "" : reader.GetString(3)
                });
            return list;
        }

        // ===== Добавление =====
        public void AddCategory(string name, string? description) => InsertNameDescription("categories", name, description);
        public void AddLocation(string name, string? description) => InsertNameDescription("locations", name, description);

        private void InsertNameDescription(string table, string name, string? description)
        {
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            using var cmd = new SqliteCommand($"INSERT INTO {table} (name, description) VALUES (@name, @desc);", connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@desc", string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description);
            cmd.ExecuteNonQuery();
        }

        public void AddStatus(string name)
        {
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            using var cmd = new SqliteCommand("INSERT INTO statuses (name) VALUES (@name);", connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
        }

        public void AddEmployee(string fullName, string? position, string? phone)
        {
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            using var cmd = new SqliteCommand(
                "INSERT INTO employees (full_name, position, phone) VALUES (@name, @pos, @phone);", connection);
            cmd.Parameters.AddWithValue("@name", fullName);
            cmd.Parameters.AddWithValue("@pos", string.IsNullOrWhiteSpace(position) ? (object)DBNull.Value : position);
            cmd.Parameters.AddWithValue("@phone", string.IsNullOrWhiteSpace(phone) ? (object)DBNull.Value : phone);
            cmd.ExecuteNonQuery();
        }

        // ===== Удаление с проверкой использования =====
        public void DeleteCategory(int id) =>
            DeleteWithCheck("categories", "category_id", id,
                "SELECT COUNT(*) FROM equipment WHERE category_id = @id;");

        public void DeleteLocation(int id) =>
            DeleteWithCheck("locations", "location_id", id,
                "SELECT (SELECT COUNT(*) FROM equipment WHERE location_id = @id) + " +
                "(SELECT COUNT(*) FROM movements WHERE from_location_id = @id OR to_location_id = @id);");

        public void DeleteStatus(int id) =>
            DeleteWithCheck("statuses", "status_id", id,
                "SELECT COUNT(*) FROM equipment WHERE status_id = @id;");

        public void DeleteEmployee(int id) =>
            DeleteWithCheck("employees", "employee_id", id,
                "SELECT (SELECT COUNT(*) FROM movements WHERE employee_id = @id) + " +
                "(SELECT COUNT(*) FROM maintenance WHERE employee_id = @id);");

        private void DeleteWithCheck(string table, string idColumn, int id, string usageSql)
        {
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();
            try
            {
                using (var pragma = new SqliteCommand("PRAGMA foreign_keys = ON;", connection, transaction))
                    pragma.ExecuteNonQuery();

                using (var check = new SqliteCommand(usageSql, connection, transaction))
                {
                    check.Parameters.AddWithValue("@id", id);
                    long used = (long)check.ExecuteScalar()!;
                    if (used > 0)
                        throw new ReferenceInUseException();
                }

                using (var del = new SqliteCommand($"DELETE FROM {table} WHERE {idColumn} = @id;", connection, transaction))
                {
                    del.Parameters.AddWithValue("@id", id);
                    del.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}