using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotys.Uzduotis9
{
    static class DataParser
    {
        public static dynamic StringToInt(string input)
        {
            bool tryParse = Int32.TryParse(input, out int output);
            if (tryParse)
            {
                return output;
            }
            else
            {
                return false;
            }
        }
    }
}
