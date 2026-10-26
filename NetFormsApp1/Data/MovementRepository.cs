using Microsoft.Data.Sqlite;
using System;

namespace NetFormsApp1.Data
{
    public class MovementRepository
    {
        public void RegisterMovement(int equipmentId, int fromLocationId, int toLocationId, int employeeId, DateTime movementDate, string? reason)
        {
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            
            using var transaction = connection.BeginTransaction(); 

            try
            {
                using (var cmdInsert = connection.CreateCommand())
                {
                    cmdInsert.Transaction = transaction;
                    cmdInsert.CommandText = @"
                        INSERT INTO movements (equipment_id, from_location_id, to_location_id, employee_id, movement_date, reason)
                        VALUES (@eq, @from, @to, @emp, @date, @reason);";
                    cmdInsert.Parameters.AddWithValue("@eq", equipmentId);
                    cmdInsert.Parameters.AddWithValue("@from", fromLocationId);
                    cmdInsert.Parameters.AddWithValue("@to", toLocationId);
                    cmdInsert.Parameters.AddWithValue("@emp", employeeId);
                    cmdInsert.Parameters.AddWithValue("@date", movementDate.ToString("yyyy-MM-dd"));
                    cmdInsert.Parameters.AddWithValue("@reason", string.IsNullOrWhiteSpace(reason) ? (object)DBNull.Value : reason);
                    cmdInsert.ExecuteNonQuery();
                }

                using (var cmdUpdate = connection.CreateCommand())
                {
                    cmdUpdate.Transaction = transaction;
                    cmdUpdate.CommandText = "UPDATE equipment SET location_id = @to WHERE equipment_id = @eq;";
                    cmdUpdate.Parameters.AddWithValue("@to", toLocationId);
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