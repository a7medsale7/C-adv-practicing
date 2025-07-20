using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
    internal abstract class TaskItem : IComparable<TaskItem>
    {
        public string Title { get; set; }
        public int Priority { get; set; }
        public bool IsCompleted { get; set; }
        public TaskItem(string title, int priority, bool isCompleted)
        {
            Title = title;
            Priority = priority;
            IsCompleted = isCompleted;
        }
        public abstract void execute();

        public int CompareTo(TaskItem other)
        { 

            if (other == null) return 1;
            if (this.Priority > other.Priority) return -1;
            if (this.Priority < other.Priority) return 1;
            else return 0;

        }
        public override string ToString()
        {
            return $"- [{this.GetType().Name}] {Title} - Priority {Priority} - Completed: {IsCompleted}";
        }
    }
}
