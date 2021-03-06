using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValuesObjects;

namespace PaymentContext.Domain.ValuesObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            this.Number = number;
            this.Type = type;
        }
        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }
    }
}