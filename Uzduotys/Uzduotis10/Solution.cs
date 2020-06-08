using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Sakoma, jei pro skylę pralenda katino galva, tai pralįs ir kūnas. Parašykite
 * programą, kuri nustatytų, ar katinas pralįs pro kvadrato formos skylę. Pradiniai
 * duomenys –katino galvos spindulys ir skylės kraštinės ilgis. Tarsime, kad
 * katino galva yra skritulio formos.
 */

namespace Uzduotys.Uzduotis10
{
    class Solution
    {
        public Solution()
        {
            Console.WriteLine("Katino galvos spindulys: ");
            bool catHeadRadiusTryParse = Double.TryParse(Console.ReadLine(), out double catHeadRadius);
            while (catHeadRadiusTryParse == false || catHeadRadius <= 0)
            {
                Console.WriteLine("Katino galvos spindulys turi būti didesnis už 0.");
                Console.WriteLine("Katino galvos spindulys: ");
                catHeadRadiusTryParse = Double.TryParse(Console.ReadLine(), out catHeadRadius);
            }

            Console.WriteLine("Kvadrato kraštinės ilgis:");
            bool sideLengthTryParse = Double.TryParse(Console.ReadLine(), out double sideLength);
            while (sideLengthTryParse == false || sideLength <= 0)
            {
                Console.WriteLine("Kvadrato kraštinės ilgis turi būti didesnis už 0.");
                Console.WriteLine("Kvadrato kraštinės ilgis:");
                sideLengthTryParse = Double.TryParse(Console.ReadLine(), out sideLength);
            }

            Console.WriteLine("Katino galvos spindulys: {0}", catHeadRadius);
            Console.WriteLine("Kraštinės ilgis: {0}", sideLength);

            if (sideLength >= catHeadRadius * 2)
            {
                Console.WriteLine("Katino galva pralys");
            }
            else
            {
                Console.WriteLine("Katino galva perdidelė įveiktį šį kvadratą");
            }

        }
    }
}
