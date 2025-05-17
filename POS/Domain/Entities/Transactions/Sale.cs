using System;
using System.Collections.Generic;

namespace POS.Domain.Entities.Transactions
{
    public class Sale
    {
        public Guid Id { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;
        public Guid CustomerId { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Navigation properties
        public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
    }
}
