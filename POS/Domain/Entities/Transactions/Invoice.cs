using System;

namespace POS.Domain.Entities.Transactions
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;
        public Guid TransactionId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal Amount { get; set; }
    }
}
