namespace POS.Domain.Entities.MasterData
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
