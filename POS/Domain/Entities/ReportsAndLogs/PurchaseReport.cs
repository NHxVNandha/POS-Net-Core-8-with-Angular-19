using System;

namespace POS.Domain.Entities.ReportsAndLogs
{
    public class PurchaseReport
    {
        public Guid PurchaseId { get; set; }
        public string SupplierName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalItems { get; set; }
    }
}
