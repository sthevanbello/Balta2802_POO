using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Payments");
            // Objeto é um tipo de referência.
            // Armazena o endereço apenas
            var customer = new Customer();
            customer.Name = "Sthevan";

            Console.WriteLine(customer.Name);

            var payment1 = new TicketPayment();
            var payment2 = new CardPayment();

            payment1.DueDate = DateTime.Now;

            Console.WriteLine(payment1);

        }

        public class Customer
        {
            public string Name { get; set; }
        }

        public class Payment
        {
            //Properties
            public DateTime DueDate { get; set; }

            //Methods
            public virtual void Pagar() { }
        }

        public class TicketPayment : Payment
        {
            public override void Pagar()
            {
                // Regra do boleto com polimorfismo (Override)
            }

            public override string ToString()
            {
                return $"Class Ticket payment - Date: {DueDate}";
            }
        }

        public class CardPayment : Payment
        {
            public string Number { get; set; }


        }
    }
}
