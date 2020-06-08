using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elektroninis laikrodis rodo laiką: valandas, minutes, sekundes (h, m, s).
 * Sudarykite programą, kuri nustatytų, kiek laiko rodys laikrodis po sekundės
 */

namespace Uzduotys.Uzduotis9
{
    class Solution
    {
        public Solution()
        {
            
            Console.WriteLine("Įveskite valandų skaičių:");
            var hours = DataParser.StringToInt(Console.ReadLine());
            while (hours is bool || !Validator.Range(hours, 0, 23))
            {
                Console.WriteLine("Netinkamai įvestas valandu skaičius. Valandos turi būti sveikasis skaičius nuo 0 iki 23");
                Console.WriteLine("Įveskite valandų skaičių:");
                hours = DataParser.StringToInt(Console.ReadLine());
            }

            Console.WriteLine("Įveskite minučių skaičių:");
            var minutes = DataParser.StringToInt(Console.ReadLine());
            while (minutes is bool || !Validator.Range(minutes, 0, 59))
            {
                Console.WriteLine("Netinkamai įvestas minučių skaičius. Minutės turi būti sveikasis skaičius nuo 0 iki 59");
                Console.WriteLine("Įveskite minučių skaičių:");
                minutes = DataParser.StringToInt(Console.ReadLine());
            }

            Console.WriteLine("Įveskite sekundžių skaičių:");
            var seconds = DataParser.StringToInt(Console.ReadLine());
            while (seconds is bool || !Validator.Range(seconds, 0, 59))
            {
                Console.WriteLine("Netinkamai įvestas sekundžių skaičius. Minutės turi būti sveikasis skaičius nuo 0 iki 59");
                Console.WriteLine("Įveskite sekundžių skaičių:");
                seconds = DataParser.StringToInt(Console.ReadLine());
            }

            Time time = new Time(hours, minutes, seconds);

            char[] choices = { 's', 'm', 'h' };
            char choice = 'x';
            while (!Array.Exists(choices, x => x == choice))
            {
                Console.WriteLine("Įveskite raidę, kokiu vienu vienetu norėtumėte padidinti laiką:");
                Console.WriteLine("s - 1 sekundė");
                Console.WriteLine("m - 1 minutė");
                Console.WriteLine("h - 1 valanda");
                choice = Convert.ToChar(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }
            
            switch (choice)
            {
                case 's':
                    time.PrintTime();
                    time.AddSecond();
                    time.PrintTime();
                    break;
                case 'm':
                    time.PrintTime();
                    time.AddMinute();
                    time.PrintTime();
                    break;
                case 'h':
                    time.PrintTime();
                    time.AddHour();
                    time.PrintTime();
                    break;
            }
        }
    }
}
