using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac
{
  abstract  class MediaItem/* : IComparable*/
    {
        public string title { get; set; }
        public int year { get; set; }

        //public int CompareTo(object obj)
        //{
        //    MediaItem other = obj as MediaItem;
        //    if (other == null) return 1;
        //    return this.year.CompareTo(other.year);

        //}

        public abstract string GetInfo();


    }
}
