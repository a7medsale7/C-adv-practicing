using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    internal interface IUser
    {
         void Login(string username, string password);
         void Logout();
       
    }
}
