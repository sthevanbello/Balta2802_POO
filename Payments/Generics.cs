using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments
{
    class Generics
    {

    }

    public class DataContext<P, PA, S>
        where P : PersonGeneric
        where PA : PaymentGeneric
        where S : SubscriptionGeneric
    {
        public void Save(P entity)
        {

        }
        public void Save(PA entity)
        {

        }
        public void Save(S entity)
        {

        }

    }
    public class PersonGeneric
    {

    }

    public class PaymentGeneric
    {

    }

    public class SubscriptionGeneric
    {

    }
}
