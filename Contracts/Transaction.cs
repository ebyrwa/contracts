namespace Contracts
{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public DateTimeOffset PostingDate { get; set; }
        public string ReferenceNumber { get; set; }
        public Guid TransactionId { get; set; }
    }
}
