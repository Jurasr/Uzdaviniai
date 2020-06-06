using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Laikrodis rodo laiką h, m. Parašykite programą, kuri apskaičiuotų kiek minučių
 * ir sekundžių prabėgo po vidurnakčio. Pvz.: h=3 ir m=5, tai m=185, s=11100
 */

namespace Uzduotys.Uzduotis4
{
    class Sprendimas
    {
        int valandos;
        int minutes;
        int sekundes;

        public Sprendimas()
        {
            Console.WriteLine("Įveskite valandų skaičių (0-23):");
            bool valandosTryParse = Int32.TryParse(Console.ReadLine(), out valandos);
            while (valandos < 0 || valandos > 23 || valandosTryParse == false)
            {
                Console.WriteLine("Netinkamas valandų skaičius. Valandos turi būti sveikasis skaičiuos nuo 0 iki 23.");
                Console.WriteLine("Įveskite valandų skaičių (0-23):");
                valandosTryParse = Int32.TryParse(Console.ReadLine(), out valandos);
            }

            Console.WriteLine("Įveskite minučių skaičių (0-59):");
            bool minutesTryParse = Int32.TryParse(Console.ReadLine(), out minutes);
            while (minutes < 0 || minutes > 59 || minutesTryParse == false)
            {
                Console.WriteLine("Netinkamas minučių skaičius. Minutės turi būti sveikasis skaičius nuo 0 iki 59.");
                Console.WriteLine("Įveskite minučių skaičių (0-59):");
                minutesTryParse = Int32.TryParse(Console.ReadLine(), out minutes);
            }

            Console.WriteLine("Įveskite sekundžių skaičių (0-59):");
            bool sekundesTryParse = Int32.TryParse(Console.ReadLine(), out sekundes);
            while (sekundes < 0 || sekundes > 59 || sekundesTryParse == false)
            {
                Console.WriteLine("Netinkamas sekundžių skaičius. Sekundės turi būti sveikasis skaičius nuo 0 iki 59.");
                Console.WriteLine("Įveskite sekundžių skaičių (0-59):");
                sekundesTryParse = Int32.TryParse(Console.ReadLine(), out sekundes);
            }

            GautiAtsakyma();
        }

        private void GautiAtsakyma()
        {
            string formatas = "";
            string[] formatai = { "s", "m", "ms" };
            string[] aprasymai = { "sekundėmis", "minutėmis", "minutėmis ir sekundėmis" };

            while (!Array.Exists(formatai, x => x == formatas))
            {
                if (formatas != "")
                {
                    Console.WriteLine("Neteisingai įvestas formatas.");
                }
                Console.WriteLine("Įveskite raides, kokiu formatu norite gauti laiką");
                for (int i = 0; i < formatai.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", formatai[i], aprasymai[i]);
                }
                formatas = Console.ReadLine();
            }

            Console.Write("Po vidurnakčio prabėgo ");
            switch (formatas)
            {
                case "s":
                    Console.WriteLine("{0} sekundės", valandos * 60 * 60 + minutes * 60);
                    break;
                case "m":
                    Console.WriteLine("{0} minutės", valandos * 60 + minutes);
                    break;
                case "ms":
                    Console.WriteLine("{0} minutės ir {1} sekundės", valandos * 60 + minutes, sekundes);
                    break;
            }
        }
    }
}
