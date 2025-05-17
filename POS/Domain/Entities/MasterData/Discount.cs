namespace POS.Domain.Entities.MasterData
{
    public class Discount
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
