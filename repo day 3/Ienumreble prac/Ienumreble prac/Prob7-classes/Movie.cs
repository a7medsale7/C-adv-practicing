using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac
{
    class Movie : MediaItem
    {
        public string Director { get; set; }

        public override string GetInfo()
        {
            return $"Movie: {title} ({year})";
        }
    }
}
