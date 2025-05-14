using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymerphism_prac
{
    class CryptoPayment : PaymentMethod
    {
        public override void Pay()
        {
            decimal interestRate = 0.15m; // 1.5% interest rate
            decimal salary = amount * interestRate;
            Console.WriteLine($"Paying {amount + interestRate:0.00} with PayPal ({walletAddress}) [Fee: {salary}]");

        }
    }
}
