using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymerphism_prac
{
    class EmailNotification:Notification
    {
        public override void Send()
        {
            Console.WriteLine($"Sending email notification to {Recipient}");
        }
        public override void Log()
        {
            Console.WriteLine($"[LOG] Email notification sent to {Recipient}");
        }
    }
}
