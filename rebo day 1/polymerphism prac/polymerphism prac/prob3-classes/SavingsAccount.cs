using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymerphism_prac
{
    class SavingsAccount : BankAccount
    {
       
        public override decimal CalculateInterest()
        {
            decimal interestRate = 0.02m; // 2% interest rate
            return Balance * interestRate;
        }


    }
}
