using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentContext.Domain.ValuesObjects;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        protected Payment(DateTime date, DateTime expireDate, decimal total, string payer, string document, decimal totalPail, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            Date = date;
            ExpireDate = expireDate;
            Total = total;
            Payer = payer;
            Document = document;
            TotalPail = totalPail;
            Address = address;
            Email = email;
        }

        public string Number { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public string Payer { get; private set; }
        public string Document { get; private set; }
        public decimal TotalPail { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }
    }
}
