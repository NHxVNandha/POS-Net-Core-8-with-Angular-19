using System;

namespace POS.Domain.Entities.Transactions
{
    public class SaleDetail
    {
        public Guid Id { get; set; }
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal => Quantity * UnitPrice;

        // Navigation property
        public virtual Sale Sale { get; set; }
    }
}
