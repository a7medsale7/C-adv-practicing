using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymerphism_prac
{
   abstract class Notification
    {
        public string Recipient { get; set; }

        public abstract void Send();

        public virtual void Log()
        {
            Console.WriteLine($"[LOG] Notification sent to {Recipient}");
        }


    }
    }

