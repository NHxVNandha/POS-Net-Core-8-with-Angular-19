using System;
using System.Collections.Generic;

namespace POS.Domain.Entities.Transactions
{
    public class Purchase
    {
        public Guid Id { get; set; }
        public string PurchaseNumber { get; set; } = string.Empty;
        public Guid SupplierId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Navigation properties
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();
    }
}
