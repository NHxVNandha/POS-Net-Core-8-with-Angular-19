using System;

namespace POS.Domain.Entities.ReportsAndLogs
{
    public class InventoryReport
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
