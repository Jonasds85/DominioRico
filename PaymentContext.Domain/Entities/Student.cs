using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentContext.Domain.ValuesObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public  class Student : Entity
    {
        private IList<Subscription> _subscription;
        public Name Name {get; private set;}
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscription.ToArray(); } } //quando usa IReadOnlyCollection, não é possivel incremetar a lista por fora        

        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscription = new List<Subscription>();

            //agrupa todas as notificações existentes nos objetos que implementão "Notifiable"
            AddNotifications(name, document, email);
        }

        public void AddSubscription(Subscription subscription)
        {
            //cancela todas as outras assinaturas e coloca esta como principal
            for (int index = 0; index < Subscriptions.Count; index++)
                _subscription[index].Inactivate();

            _subscription.Add(subscription);
        }
    }
}
