using NetFormsApp1.Models;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using NetFormsApp1.Data;

namespace ComputerClubEquipment.Data
{
    public class EquipmentRepository
    {
        public List<Equipment> GetAll()
        {
            var equipmentList = new List<Equipment>();
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();

            // Тот самый JOIN запрос из твоего Приложения В, но возвращающий объекты
            string sql = @"
                SELECT e.equipment_id, e.inventory_number, e.serial_number, e.name, 
                       c.category_id, c.name as category_name,
                       l.location_id, l.name as location_name,
                       s.status_id, s.name as status_name,
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
                equipmentList.Add(new Equipment
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
            return equipmentList;
        }

        public void Add(Equipment eq)
        {
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            string sql = @"INSERT INTO equipment (inventory_number, serial_number, name, category_id, location_id, status_id, purchase_date, price, notes) 
                           VALUES (@inv, @sn, @name, @cat, @loc, @stat, @date, @price, @notes)";
            
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@inv", eq.InventoryNumber);
            command.Parameters.AddWithValue("@sn", string.IsNullOrEmpty(eq.SerialNumber) ? (object)DBNull.Value : eq.SerialNumber);
            command.Parameters.AddWithValue("@name", eq.Name);
            command.Parameters.AddWithValue("@cat", eq.CategoryId);
            command.Parameters.AddWithValue("@loc", eq.LocationId);
            command.Parameters.AddWithValue("@stat", eq.StatusId);
            command.Parameters.AddWithValue("@date", string.IsNullOrEmpty(eq.PurchaseDate) ? (object)DBNull.Value : eq.PurchaseDate);
            command.Parameters.AddWithValue("@price", eq.Price);
            command.Parameters.AddWithValue("@notes", string.IsNullOrEmpty(eq.Notes) ? (object)DBNull.Value : eq.Notes);
            
            command.ExecuteNonQuery();
        }
    }
}