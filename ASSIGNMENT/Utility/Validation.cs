using System.Text.RegularExpressions;

namespace ASSIGNMENT.Utility
{
    internal class Validation
    {
        public static bool isNumber(string value)
        {
            return Regex.IsMatch(value, @"^(0)[0-9]+$");
        }

        public static bool isAlpabetic(string value)
        {
            return Regex.IsMatch(value.Trim(), @"[a-zA-Z]+$");
        }

        public static bool isMaSv(string value)
        {
            return Regex.IsMatch(value, @"^(PH)[0-9]{5}$");
        }

        public static bool isScores(string value)
        {
            return Regex.IsMatch(value, @"^[0-9]\.?[0-9]?$");
        }
    }
}
