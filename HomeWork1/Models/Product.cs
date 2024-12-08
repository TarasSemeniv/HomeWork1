namespace HomeWork1.Models
{
    public class Product
    {
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public Category? Category { get; set; }
        public DateTime? DateOfManufacture {  get; set; }
    }
}
