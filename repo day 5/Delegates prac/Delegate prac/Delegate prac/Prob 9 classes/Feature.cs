using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
    internal class Feature : TaskItem
    {
        public DateTime Deadline { get; set; }

        public Feature(string title, int priority, bool isCompleted, DateTime deadline)
            : base(title, priority, isCompleted)
        {
            Deadline = deadline;
        }

        public override void execute()
        {
            Console.WriteLine($"- Executing: {Title}");
        }
    }
}

