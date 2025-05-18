using System;

namespace POS.Domain.Entities.ReportsAndLogs
{
    public class SalesReport
    {
        public Guid SaleId { get; set; }
        public string CustomerName { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalItems { get; set; }
    }
}
