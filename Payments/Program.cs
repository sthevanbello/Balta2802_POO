using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var payments = new List<PaymentGeneric>();

            payments.Add(new PaymentGeneric(1));
            payments.Add(new PaymentGeneric(2));
            payments.Add(new PaymentGeneric(3));
            payments.Add(new PaymentGeneric(4));
            payments.Add(new PaymentGeneric(5));
            payments.Add(new PaymentGeneric(6));


            foreach (var payment in payments)
            {
                Console.WriteLine(payment.Id);
            }
            
            Console.ReadKey();
        }

        
    }
}
