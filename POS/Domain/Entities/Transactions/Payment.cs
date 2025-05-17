using System;

namespace POS.Domain.Entities.Transactions
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid TransactionId { get; set; }  // Bisa merujuk ke Sale atau Purchase (opsional bisa diperluas)
        public string PaymentMethod { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
