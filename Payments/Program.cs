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
            void Pagar(){}
        }
    }
}
