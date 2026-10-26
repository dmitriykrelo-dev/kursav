using Microsoft.Data.Sqlite;
using System;

namespace NetFormsApp1.Data
{
    public class MaintenanceRepository
    {
        public void RegisterMaintenance(int equipmentId, int employeeId, DateTime maintenanceDate,
            string maintenanceType, string? description, decimal cost, DateTime? nextDate, int newStatusId)
        {
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {
                // 1. Записываем сведения об обслуживании
                using (var cmdInsert = connection.CreateCommand())
                {
                    cmdInsert.Transaction = transaction;
                    cmdInsert.CommandText = @"
                        INSERT INTO maintenance (equipment_id, employee_id, maintenance_date, maintenance_type, description, cost, next_date)
                        VALUES (@eq, @emp, @date, @type, @desc, @cost, @next);";
                    cmdInsert.Parameters.AddWithValue("@eq", equipmentId);
                    cmdInsert.Parameters.AddWithValue("@emp", employeeId);
                    cmdInsert.Parameters.AddWithValue("@date", maintenanceDate.ToString("yyyy-MM-dd"));
                    cmdInsert.Parameters.AddWithValue("@type", maintenanceType);
                    cmdInsert.Parameters.AddWithValue("@desc", string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description);
                    cmdInsert.Parameters.AddWithValue("@cost", cost);
                    cmdInsert.Parameters.AddWithValue("@next", nextDate == null ? (object)DBNull.Value : nextDate.Value.ToString("yyyy-MM-dd"));
                    cmdInsert.ExecuteNonQuery();
                }

                // 2. Обновляем статус оборудования
                using (var cmdUpdate = connection.CreateCommand())
                {
                    cmdUpdate.Transaction = transaction;
                    cmdUpdate.CommandText = "UPDATE equipment SET status_id = @status WHERE equipment_id = @eq;";
                    cmdUpdate.Parameters.AddWithValue("@status", newStatusId);
                    cmdUpdate.Parameters.AddWithValue("@eq", equipmentId);
                    cmdUpdate.ExecuteNonQuery();
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