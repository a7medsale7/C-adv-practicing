using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac
{
    class Documentary : MediaItem
    {
        public string Topic { get; set; }

        public override string GetInfo()
        {
            return $"Documentary: {title} ({year})";
        }
    }
}
