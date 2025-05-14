using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymerphism_prac
{
    abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }

        public decimal Balance { get; set; }
        public abstract decimal CalculateInterest();
        



    }
}
