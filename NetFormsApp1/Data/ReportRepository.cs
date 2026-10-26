using System.Data;
using Microsoft.Data.Sqlite;

namespace NetFormsApp1.Data
{
    public class ReportRepository
    {
        public DataTable GetFullRegistry() => ExecuteQuery(@"
            SELECT e.inventory_number AS [Инв. номер], e.name AS [Наименование],
                   c.name AS [Категория], l.name AS [Место], s.name AS [Статус], e.price AS [Цена]
            FROM equipment e
            JOIN categories c ON c.category_id = e.category_id
            JOIN locations l ON l.location_id = e.location_id
            JOIN statuses s ON s.status_id = e.status_id
            ORDER BY e.inventory_number");

        public DataTable GetMovements() => ExecuteQuery(@"
            SELECT m.movement_date AS [Дата], e.inventory_number AS [Инв. номер], e.name AS [Оборудование],
                   l1.name AS [Откуда], l2.name AS [Куда], emp.full_name AS [Сотрудник]
            FROM movements m
            JOIN equipment e ON e.equipment_id = m.equipment_id
            LEFT JOIN locations l1 ON l1.location_id = m.from_location_id
            JOIN locations l2 ON l2.location_id = m.to_location_id
            JOIN employees emp ON emp.employee_id = m.employee_id
            ORDER BY m.movement_date DESC");

        public DataTable GetMaintenance() => ExecuteQuery(@"
            SELECT m.maintenance_date AS [Дата], e.inventory_number AS [Инв. номер], e.name AS [Оборудование],
                   m.maintenance_type AS [Тип работ], m.cost AS [Стоимость], emp.full_name AS [Сотрудник]
            FROM maintenance m
            JOIN equipment e ON e.equipment_id = m.equipment_id
            JOIN employees emp ON emp.employee_id = m.employee_id
            ORDER BY m.maintenance_date DESC");

        private DataTable ExecuteQuery(string sql)
        {
            var table = new DataTable();
            using var connection = new SqliteConnection(DatabaseHelper.ConnectionString);
            connection.Open();
            using var cmd = new SqliteCommand(sql, connection);
            using var reader = cmd.ExecuteReader();
            table.Load(reader);
            return table;
        }
    }
}