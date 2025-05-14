using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_properites_prac
{
     interface IProduct
    {
        string Name { get; set; }
        int price { get; set; }
        int stock { get; set; }
        void display();

    }
}
