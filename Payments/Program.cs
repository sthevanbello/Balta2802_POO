using System;
using System.Threading.Channels;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {

            //var contextPerson = new DataContext<PersonGeneric>();
            //var contextPayment = new DataContext<PaymentGeneric>();

            //var person = new PersonGeneric();
            //var payment = new PaymentGeneric();

            //contextPerson.Save(person);
            //contextPayment.Save(payment);

            var context = new DataContext<PersonGeneric, PaymentGeneric, SubscriptionGeneric>();

            var person = new PersonGeneric();
            var payment = new PaymentGeneric();
            var subscription = new SubscriptionGeneric();

            context.Save(person);
            context.Save(payment);
            context.Save(subscription);
        }

        
    }
}
