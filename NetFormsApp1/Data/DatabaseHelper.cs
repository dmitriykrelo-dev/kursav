using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace NetFormsApp1.Data
{
    public static class DatabaseHelper
    {
        public static string DbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "equipment.db");
        public static string ConnectionString => $"Data Source={DbPath};";

        public static void InitializeDatabase()
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            Execute(connection, "PRAGMA foreign_keys = ON;");
            Execute(connection, SchemaScript);

            if (IsEmpty(connection, "statuses"))   Execute(connection, StatusesSeed);
            if (IsEmpty(connection, "categories")) Execute(connection, CategoriesSeed);
            if (IsEmpty(connection, "locations"))  Execute(connection, LocationsSeed);
            if (IsEmpty(connection, "employees"))  Execute(connection, EmployeesSeed);
            if (IsEmpty(connection, "equipment"))  Execute(connection, EquipmentSeed);

            // Пользователи создаются с НАСТОЯЩИМИ SHA-256 хэшами паролей (п. 1.3 курсового)
            if (IsEmpty(connection, "users"))
            {
                InsertUser(connection, "admin", "admin123", "Администратор системы", "admin");
                InsertUser(connection, "operator", "operator123", "Оператор клуба", "operator");
            }

            // Если БД была создана старой версией программы — заменяем демо-хэши на настоящие
            MigrateDemoPasswords(connection);
        }

        // ===== Хэширование пароля по SHA-256 =====
        public static string HashPassword(string password)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            byte[] bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return Convert.ToHexString(bytes).ToLowerInvariant();
        }

        private static void InsertUser(SqliteConnection connection, string login, string password, string fullName, string role)
        {
            using var cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO users (login, password_hash, full_name, role) VALUES (@login, @hash, @name, @role);";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@hash", HashPassword(password));
            cmd.Parameters.AddWithValue("@name", fullName);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.ExecuteNonQuery();
        }

        private static void MigrateDemoPasswords(SqliteConnection connection)
        {
            UpdateOldHash(connection, "admin", "hash_example_admin", "admin123");
            UpdateOldHash(connection, "operator", "hash_example_operator", "operator123");
        }

        private static void UpdateOldHash(SqliteConnection connection, string login, string oldHash, string newPassword)
        {
            using var cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE users SET password_hash = @new WHERE login = @login AND password_hash = @old;";
            cmd.Parameters.AddWithValue("@new", HashPassword(newPassword));
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@old", oldHash);
            cmd.ExecuteNonQuery();
        }

        private static bool IsEmpty(SqliteConnection connection, string table)
        {
            using var cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT COUNT(*) FROM {table};";
            return Convert.ToInt64(cmd.ExecuteScalar()) == 0;
        }

        private static void Execute(SqliteConnection connection, string sql)
        {
            using var cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        // ===== Скрипт из Приложения Б твоего курсового =====
        private const string SchemaScript = @"
            CREATE TABLE IF NOT EXISTS users (user_id INTEGER PRIMARY KEY AUTOINCREMENT, login TEXT NOT NULL UNIQUE, password_hash TEXT NOT NULL, full_name TEXT NOT NULL, role TEXT NOT NULL CHECK(role IN ('admin', 'operator')));
            CREATE TABLE IF NOT EXISTS categories (category_id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT NOT NULL UNIQUE, description TEXT);
            CREATE TABLE IF NOT EXISTS locations (location_id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT NOT NULL UNIQUE, description TEXT);
            CREATE TABLE IF NOT EXISTS statuses (status_id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT NOT NULL UNIQUE);
            CREATE TABLE IF NOT EXISTS employees (employee_id INTEGER PRIMARY KEY AUTOINCREMENT, full_name TEXT NOT NULL, position TEXT, phone TEXT);
            CREATE TABLE IF NOT EXISTS equipment (equipment_id INTEGER PRIMARY KEY AUTOINCREMENT, inventory_number TEXT NOT NULL UNIQUE, serial_number TEXT, name TEXT NOT NULL, category_id INTEGER NOT NULL, location_id INTEGER NOT NULL, status_id INTEGER NOT NULL, purchase_date TEXT, price REAL, notes TEXT, FOREIGN KEY (category_id) REFERENCES categories(category_id), FOREIGN KEY (location_id) REFERENCES locations(location_id), FOREIGN KEY (status_id) REFERENCES statuses(status_id));
            CREATE TABLE IF NOT EXISTS movements (movement_id INTEGER PRIMARY KEY AUTOINCREMENT, equipment_id INTEGER NOT NULL, from_location_id INTEGER, to_location_id INTEGER NOT NULL, employee_id INTEGER NOT NULL, movement_date TEXT NOT NULL, reason TEXT, FOREIGN KEY (equipment_id) REFERENCES equipment(equipment_id), FOREIGN KEY (from_location_id) REFERENCES locations(location_id), FOREIGN KEY (to_location_id) REFERENCES locations(location_id), FOREIGN KEY (employee_id) REFERENCES employees(employee_id));
            CREATE TABLE IF NOT EXISTS maintenance (maintenance_id INTEGER PRIMARY KEY AUTOINCREMENT, equipment_id INTEGER NOT NULL, employee_id INTEGER NOT NULL, maintenance_date TEXT NOT NULL, maintenance_type TEXT NOT NULL, description TEXT, cost REAL, next_date TEXT, FOREIGN KEY (equipment_id) REFERENCES equipment(equipment_id), FOREIGN KEY (employee_id) REFERENCES employees(employee_id));";

        // ===== Начальное наполнение (Приложение Б) =====
        private const string StatusesSeed = @"INSERT INTO statuses (name) VALUES ('В работе'), ('На обслуживании'), ('В ремонте'), ('Списано');";

        private const string CategoriesSeed = @"INSERT INTO categories (name, description) VALUES
            ('Компьютеры', 'Системные блоки, игровые ПК, моноблоки'),
            ('Мониторы', 'Мониторы и дисплеи'),
            ('Периферия', 'Клавиатуры, мыши, гарнитуры, веб-камеры'),
            ('Сетевое оборудование', 'Роутеры, коммутаторы, точки доступа'),
            ('Серверное оборудование', 'Серверы и СХД'),
            ('Электропитание', 'ИБП, сетевые фильтры, стабилизаторы');";

        private const string LocationsSeed = @"INSERT INTO locations (name, description) VALUES
            ('Зал 1', 'Основной игровой зал'), ('Зал 2', 'Дополнительный зал'),
            ('VIP-зона', 'Зона повышенной комфортности'), ('Серверная', 'Помещение серверного оборудования'),
            ('Склад', 'Складское помещение');";

        private const string EmployeesSeed = @"INSERT INTO employees (full_name, position, phone) VALUES
            ('Иванов Иван Иванович', 'Системный администратор', '+7 900 111-22-33'),
            ('Петров Пётр Петрович', 'Техник', '+7 900 222-33-44');";

        private const string EquipmentSeed = @"INSERT INTO equipment (inventory_number, serial_number, name, category_id, location_id, status_id, purchase_date, price, notes) VALUES
            ('INV-0001', 'SN-PC-1001', 'Игровой ПК Zeus', 1, 1, 1, '2024-05-12', 120000, 'i7-13700K, RTX 4070'),
            ('INV-0002', 'SN-PC-1002', 'Игровой ПК Zeus', 1, 1, 1, '2024-05-12', 120000, NULL),
            ('INV-0003', 'SN-MON-2001', 'Монитор Samsung Odyssey G7', 2, 1, 1, '2024-06-01', 45000, NULL),
            ('INV-0004', 'SN-MON-2002', 'Монитор Samsung Odyssey G7', 2, 2, 3, '2024-06-01', 45000, 'Мерцает изображение'),
            ('INV-0005', 'SN-KB-3001', 'Клавиатура Logitech G Pro', 3, 2, 1, '2024-07-15', 9000, NULL),
            ('INV-0006', 'SN-ROUT-4001', 'Роутер MikroTik RB4011', 4, 4, 1, '2023-11-20', 18000, NULL),
            ('INV-0007', 'SN-UPS-5001', 'ИБП APC Smart-UPS 1500', 6, 4, 2, '2023-11-20', 32000, 'Замена батареи по плану'),
            ('INV-0008', 'SN-PC-1003', 'Игровой ПК Ares', 1, 3, 1, '2025-01-10', 150000, 'VIP-зона');";
    }
}