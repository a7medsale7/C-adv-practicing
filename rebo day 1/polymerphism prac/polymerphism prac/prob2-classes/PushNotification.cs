using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymerphism_prac
{
    class PushNotification:Notification
    {
        public override void Send()
        {
            Console.WriteLine($"Sending push notification to {Recipient}");
        }
        public override void Log()
        {
            Console.WriteLine($"[LOG] Push notification sent to {Recipient}");
        }
    }
}
