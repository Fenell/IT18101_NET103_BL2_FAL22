using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TRAINING_3.Models;

namespace TRAINING_3.Utilities
{
    internal class Utility
    {
        public static Role Role;
        public static Account Account;

        public static bool CheckNullLabe(TextBox str)
        {
            if (string.IsNullOrEmpty(str.Text.Trim()))
            {
                str.Focus();
                return true;
            }
            return false;
        }

        public static bool CheckNumber(string num)
        {
            return !Regex.IsMatch(num, @"^[0-9]{10,13}+$");
        }
    }
}
