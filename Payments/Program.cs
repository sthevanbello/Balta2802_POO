using System;
using System.Collections.Generic;
using System.Linq;
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

            var paymentsWhere = payments.Where(x => x.Id == 3);
            var paymentsFirst = payments.FirstOrDefault(x => x.Id == 3);

            foreach (var item in paymentsWhere)
            {
                Console.WriteLine(item.Id);
            }
            Console.WriteLine(paymentsFirst);


            Console.ReadKey();
        }


    }
}
