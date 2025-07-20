using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
    internal class Book : Product 
    {
        public string Author { get; set; }




        public override string GetInfo()
        {
            return $"Book: {Name} by {Author} - {Price} EGP";
        }
    }
}
