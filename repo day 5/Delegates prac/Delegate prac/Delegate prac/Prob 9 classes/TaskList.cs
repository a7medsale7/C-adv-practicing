using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
    internal class TaskList<T>: IEnumerable<T> where T : TaskItem, IComparable<T>   
    {
        private List<T> tasks = new List<T>();

        public void Add(T task) => tasks.Add(task);

        public T this[int index]
        {
            get
            {
                foreach (var task in tasks)
                {
                    if (task is null)
                        throw new ArgumentOutOfRangeException(nameof(index), "Index out of range or task is null.");
                }
                if (index < 0 || index >= tasks.Count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Index out of range.");
                return tasks[index];
            }
           
        }

        public IEnumerator<T> GetEnumerator() => tasks.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public List<T> Filter(Func<T, bool> predicate) => tasks.Where(predicate).ToList();

        public void Log(Action<T> action)
        {
            foreach (var task in tasks)
                action(task);
        }

        public List<T> SortedByPriority()
        {
            var sorted = new List<T>(tasks);
            sorted.Sort(); 
            return sorted;
        }

        public List<T> SortedByTitle()
        {
            var sorted = new List<T>(tasks);
            sorted.Sort(new TaskTitleComparer());
            return sorted;
        }
    }
}
