using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASSIGNMENT_1.Utility
{
    internal class Validation
    {
        public static bool IsPhoneNumber(string value)
        {
            return Regex.IsMatch(value, @"^(0)[0-9]+$");
        }

        public static bool IsAlpabetic(string value)
        {
            return Regex.IsMatch(value.Trim(), @"[a-zA-Z]+$");
        }

        public static bool IsMaSv(string value)
        {
            return Regex.IsMatch(value, @"^(PH)[0-9]{5}$");
        }

        public static bool IsScores(string value)
        {
            return Regex.IsMatch(value, @"^[0-9]\.?[0-9]?$");
        }

        public static bool IsEmail(string value)
        {
            return Regex.IsMatch(value, @"[\w]+@(fpt.edu.vn)");
        }
    }
}
