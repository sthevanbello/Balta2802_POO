using MaoNaMassaPOO.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaPOO.SubscriptionContext
{
    public class User : Base
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
