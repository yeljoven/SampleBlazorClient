using System;

namespace BankRup.Models
{
    public class Transaction
    {
        public Guid From { get; set; }
        public Guid To { get; set; }
        public decimal Amount { get; set; }
    }
}