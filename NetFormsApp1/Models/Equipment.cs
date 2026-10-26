namespace NetFormsApp1.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string? InventoryNumber { get; set; }
        public string? SerialNumber { get; set; }
        public string? Name { get; set; }
        
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        
        public int LocationId { get; set; }
        public string? LocationName { get; set; }
        
        public int StatusId { get; set; }
        public string? StatusName { get; set; }
        
        public string? PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public string? Notes { get; set; }
    }
}