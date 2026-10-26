namespace NetFormsApp1.Models
{
    public class CategoryItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class EmployeeItem
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Position { get; set; }
        public string? Phone { get; set; }
    }
}