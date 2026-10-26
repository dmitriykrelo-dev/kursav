using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using NetFormsApp1.Models;

namespace NetFormsApp1.Data
{
    public class EquipmentRepository
    {
        public List<Equipment> GetAll()
        {
            var list = new List<Equipment>();
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();

            string sql = @"
                SELECT e.equipment_id, e.inventory_number, e.serial_number, e.name,
                       c.category_id, c.name, l.location_id, l.name, s.status_id, s.name,
                       e.purchase_date, e.price, e.notes
                FROM equipment e
                JOIN categories c ON c.category_id = e.category_id
                JOIN locations l ON l.location_id = e.location_id
                JOIN statuses s ON s.status_id = e.status_id
                ORDER BY e.inventory_number";

            using var command = new SqliteCommand(sql, connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Equipment
                {
                    EquipmentId = reader.GetInt32(0),
                    InventoryNumber = reader.GetString(1),
                    SerialNumber = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    Name = reader.GetString(3),
                    CategoryId = reader.GetInt32(4),
                    CategoryName = reader.GetString(5),
                    LocationId = reader.GetInt32(6),
                    LocationName = reader.GetString(7),
                    StatusId = reader.GetInt32(8),
                    StatusName = reader.GetString(9),
                    PurchaseDate = reader.IsDBNull(10) ? "" : reader.GetString(10),
                    Price = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11),
                    Notes = reader.IsDBNull(12) ? "" : reader.GetString(12)
                });
            }
            return list;
        }

        public List<ReferenceItem> GetCategories() => GetReferenceList("categories", "category_id");
        public List<ReferenceItem> GetLocations()  => GetReferenceList("locations", "location_id");
        public List<ReferenceItem> GetStatuses()   => GetReferenceList("statuses", "status_id");
        // У таблицы employees колонка с именем называется full_name (Приложение А)!
        public List<ReferenceItem> GetEmployees()  => GetReferenceList("employees", "employee_id", "full_name");

        private List<ReferenceItem> GetReferenceList(string table, string idColumn, string nameColumn = "name")
        {
            var list = new List<ReferenceItem>();
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            using var command = new SqliteCommand(
                $"SELECT {idColumn}, {nameColumn} FROM {table} ORDER BY {nameColumn};", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
                list.Add(new ReferenceItem { Id = reader.GetInt32(0), Name = reader.GetString(1) });
            return list;
        }

        public void Add(Equipment eq)
        {
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            string sql = @"INSERT INTO equipment (inventory_number, serial_number, name, category_id,
                           location_id, status_id, purchase_date, price, notes)
                           VALUES (@inv, @sn, @name, @cat, @loc, @stat, @date, @price, @notes)";
            FillParameters(connection, sql, eq).ExecuteNonQuery();
        }

        public void Update(Equipment eq)
        {
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            string sql = @"UPDATE equipment SET inventory_number=@inv, serial_number=@sn, name=@name,
                           category_id=@cat, location_id=@loc, status_id=@stat,
                           purchase_date=@date, price=@price, notes=@notes
                           WHERE equipment_id=@id";
            var cmd = FillParameters(connection, sql, eq);
            cmd.Parameters.AddWithValue("@id", eq.EquipmentId);
            cmd.ExecuteNonQuery();
        }
        private SqliteCommand FillParameters(SqliteConnection connection, string sql, Equipment eq)
        {
            var cmd = new SqliteCommand(sql, connection);
            cmd.Parameters.AddWithValue("@inv", eq.InventoryNumber);
            cmd.Parameters.AddWithValue("@sn", string.IsNullOrEmpty(eq.SerialNumber) ? (object)DBNull.Value : eq.SerialNumber);
            cmd.Parameters.AddWithValue("@name", eq.Name);
            cmd.Parameters.AddWithValue("@cat", eq.CategoryId);
            cmd.Parameters.AddWithValue("@loc", eq.LocationId);
            cmd.Parameters.AddWithValue("@stat", eq.StatusId);
            cmd.Parameters.AddWithValue("@date", string.IsNullOrEmpty(eq.PurchaseDate) ? (object)DBNull.Value : eq.PurchaseDate);
            cmd.Parameters.AddWithValue("@price", eq.Price);
            cmd.Parameters.AddWithValue("@notes", string.IsNullOrEmpty(eq.Notes) ? (object)DBNull.Value : eq.Notes);
            return cmd;
        }
    }
}