namespace NetFormsApp1.Models
{
    public class ReferenceItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        // Благодаря этому ComboBox будет показывать название, а не тип объекта
        public override string ToString() => Name ?? "";
    }
}