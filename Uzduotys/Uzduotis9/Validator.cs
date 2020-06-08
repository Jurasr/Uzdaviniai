using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotys.Uzduotis9
{
    static class Validator
    {
        public static bool Min(int input, int min)
        {
            if (input >= min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Max(int input, int max)
        {
            if (input <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Range(int input, int min, int max)
        {
            if (input >= min && input <= max)
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
