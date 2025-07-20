using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
    internal class TaskTitleComparer : IComparer<TaskItem>
    {
        public int Compare(TaskItem x, TaskItem y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }
}
