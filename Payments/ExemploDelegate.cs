using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments
{
    public class ExemploDelegate
    {
        public static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago o valor de {valor}");
        }
    }
}
