namespace POS.Domain.Entities.MasterData
{
    public class Tax
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Percentage { get; set; }
    }
}
