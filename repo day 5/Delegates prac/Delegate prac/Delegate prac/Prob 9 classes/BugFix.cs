using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
    internal class BugFix : TaskItem
    {
        public string Developer { get; set; }

        public BugFix(string title, int priority, bool isCompleted, string developer)
            : base(title, priority, isCompleted)
        {
            Developer = developer;
        }

        public override void execute()
        {
            Console.WriteLine($"- Executing: {Title}");
        }
    }
}
