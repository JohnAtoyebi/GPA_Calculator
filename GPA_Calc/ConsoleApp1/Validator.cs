using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GPA
{
    public static class Validator
    {
        public static bool EmptyChecker(string input)
        {
            if (input == null)
            {
                return false;
            }
            return true;
        }

        public static bool CourseCodeChecker(string input)
        {
            if (input.Length == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CourseUnitChecker(string input)
        {
            var value = Convert.ToInt32(input);
            if (value >= 0 && value <= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ScoreChecker(string input)
        {
            var value = Convert.ToInt32(input);
            int.TryParse(input, out int a);
            if (value >= 0 && value <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
