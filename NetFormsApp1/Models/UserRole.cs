namespace NetFormsApp1.Models
{
    public enum UserRole
    {
        Admin,       // Администратор
        Operator,    // Оператор зала
        Technician,  // Техник / Сисадмин
        Accountant,  // Бухгалтер / Менеджер
        Viewer       // Наблюдатель (только чтение)
    }

    public static class UserRoleExtensions
    {
        // Помощник для преобразования строки из БД в enum
        public static UserRole ToRole(this string roleString)
        {
            return roleString.ToLower() switch
            {
                "admin" => UserRole.Admin,
                "operator" => UserRole.Operator,
                "technician" => UserRole.Technician,
                "accountant" => UserRole.Accountant,
                "viewer" => UserRole.Viewer,
                _ => UserRole.Viewer // По умолчанию
            };
        }
    }
}