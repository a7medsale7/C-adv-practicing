using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymerphism_prac
{
    class FixedDepositAccount : BankAccount
    {

        public override decimal CalculateInterest()
        {
            decimal interestRate = 0.08m; // 8% interest rate
            return Balance * interestRate;
        }


    }
}
