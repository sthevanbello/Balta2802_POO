using System;
using System.Threading.Channels;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {

            var pagar = new Pagamento.Pagar(ExemploDelegate.RealizarPagamento);
            pagar(valor:1500);

            Console.ReadKey();
        }
       
    }
}
