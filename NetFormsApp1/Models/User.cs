namespace NetFormsApp1.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? Login { get; set; }
        public string? FullName { get; set; }
        public UserRole Role { get; set; } 
    }
}