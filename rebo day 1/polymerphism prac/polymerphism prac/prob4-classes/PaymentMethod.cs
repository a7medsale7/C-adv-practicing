using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymerphism_prac
{
    abstract class PaymentMethod
    {
        public string cardNumber { get; set; }
        public string Email { get; set; }
        public string walletAddress { get; set; }

        public decimal amount { get; set; }
        public string type { get; set; }
        public abstract void Pay();
    }
}
