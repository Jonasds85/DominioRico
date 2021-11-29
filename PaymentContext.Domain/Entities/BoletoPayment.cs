using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentContext.Domain.ValuesObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(
            string barCode, 
            string boletoNumber,
            DateTime date,
            DateTime expireDate,
            decimal total,
            string payer,
            string document,
            decimal totalPail,
            Address address,
            Email email) : base(date, expireDate, total, payer, document, totalPail, address, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}
