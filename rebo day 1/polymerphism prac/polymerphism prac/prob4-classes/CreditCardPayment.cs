using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymerphism_prac
{
    class CreditCardPayment : PaymentMethod
    {
        public override void Pay()
        {
            decimal interestRate = 0.02m; // 2% interest rate
            decimal salary = amount * interestRate;

            Console.WriteLine($"Paying {amount + interestRate:0.00} with Credit Card ({cardNumber}) [Fee: {salary}]");
        }
    }
}
