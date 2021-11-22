using System;
using System.Threading.Channels;

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

            //var payment = new Payment();

            Console.WriteLine(payment1);

        }
        // sealed deixa a classe proibida de ser instanciada
        //public sealed class Payment

        // Classe abstrata para evitar instâncias
        public abstract class Payment
        //public class Payment
        {
            //Properties
            public DateTime DueDate { get; set; }

            public Payment()
            {
                Console.WriteLine("Construtor da classe base Payment");
            }


            //Methods
            public virtual void Pagar() { }
        }

        public class Customer
        {
            public string Name { get; set; }
        }

        public class TicketPayment : Payment, IPayment
        {
            public override void Pagar()
            {
                // Regra do boleto com polimorfismo (Override)
            }

            public override string ToString()
            {
                return $"Class Ticket payment - Date: {DueDate}";
            }

            //Implemented by interface
            public void PaymentMethod()
            {
                Console.WriteLine("Payment method implemented by interface");
            }
        }

        public class CardPayment : Payment
        {
            public string Number { get; set; }


        }

        // Example Interface
        public interface IPayment
        {
            void PaymentMethod();

        }
    }
}
