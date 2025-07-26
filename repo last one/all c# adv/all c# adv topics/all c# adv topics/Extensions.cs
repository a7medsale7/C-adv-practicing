using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    internal static class Extensions
    {
        public static string GenerateUsername(this string fullName)
        {
            return fullName.ToLower();
        }
        public static bool IsEmailValid(this string email)
        {
            return email.Contains("@");
        }

    }
}
