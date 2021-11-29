using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValuesObjects;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentsTests
    {
        [TestMethod]
        public void TestMethod()
        {
            //var subscription = new Subscription(null);
            //var student = new Student(
            //    new Name("Jonas", "Santos"), 
            //    new Document("123456789", EDocumentType.CNPJ), 
            //    new Email("jonasds@outlook.com"));
            //student.AddSubscription(subscription);
            var name = new Name("Jonas", "Santos");
            if (!name.IsValid)
            {
                //name.Notifications;
            }

            foreach(var not in name.Notifications)
            {
                var teste = not.Message;
            }

            


        }
    }
}
