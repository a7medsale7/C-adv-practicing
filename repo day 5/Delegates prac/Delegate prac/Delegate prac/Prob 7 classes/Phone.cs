using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
    internal class Phone : Product
    {
        public string Brand { get; set; }
        public override string GetInfo()
        {
            return $"Book: {Name} by {Brand} - {Price} EGP";
        }

    }
}
