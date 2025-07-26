using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    public class Logger
    {
        public LogHandler log; 

        public void LogToConsole(string msg)
        {
            Console.WriteLine("LOG: " + msg);
        }

        public void LogWithTimestamp(string msg)
        {
            Console.WriteLine($"[{DateTime.Now}] {msg}");
        }

        public void LogAction(string msg)
        {
            if (log != null)
                log(msg); 
        }
    }

}
