using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace polymerphism_prac
{
    class PayPalPayment : PaymentMethod
    {
        public override void Pay()
        { 
            decimal interestRate = 0.03m; // 3% interest rate

            decimal salary = amount * interestRate;
            Console.WriteLine($"Paying {amount + interestRate:0.00} with PayPal ({Email}) [Fee: {salary}]");

        }
    }
}
