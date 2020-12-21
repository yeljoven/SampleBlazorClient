using System;

namespace BankRup.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public decimal Balance { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public Guid Guid { get; set; }
    }
}