using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentContext.Domain.ValuesObjects;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(
            string transactionCode, 
            DateTime date, 
            DateTime expireDate, 
            decimal total, 
            string payer, 
            string document, 
            decimal totalPail,
            Address address, 
            Email email) : base(date, expireDate, total, payer, document, totalPail, address, email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}
