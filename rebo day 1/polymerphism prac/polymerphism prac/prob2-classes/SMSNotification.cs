using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymerphism_prac
{
    class SMSNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine($"Sending SMS notification to {Recipient}");
        }
        public override void Log()
        {
            Console.WriteLine($"[LOG] SMS notification sent to {Recipient}");
        }

    }

    }

