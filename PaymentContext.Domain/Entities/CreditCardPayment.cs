using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentContext.Domain.ValuesObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(
            string cardHoldName, 
            string cardNumber, 
            string lastTransactionNumber,
            DateTime date,
            DateTime expireDate,
            decimal total,
            string payer,
            string document,
            decimal totalPail,
            Address address,
            Email email) : base(date, expireDate, total, payer, document, totalPail, address, email)
        {
            CardHoldName = cardHoldName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHoldName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}
