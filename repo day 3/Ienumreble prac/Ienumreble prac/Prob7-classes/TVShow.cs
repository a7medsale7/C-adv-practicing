using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac
{
    class TVShow : MediaItem
    {

        public int Seasons { get; set; }

        public override string GetInfo()
        {
            return $"TV Show: {title} ({year})";
        }
    }
}
