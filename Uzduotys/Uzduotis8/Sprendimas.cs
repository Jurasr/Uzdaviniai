using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Senį besmegenį sudaro trys sniego rutuliai. Popieriuje jie atrodo kaip skrituliai.
 * Mažiausio skritulio spindulys r. Sudarykite programą, kuri apskaičiuotų
 * kiekvieno skritulio plotą, jei kitų apskritimų spinduliai 2 kartus didesni už pries
 * tai esantį. Pasitikrinkite: r=1, tai skritulių plotai 3.14, 12.56 ir 50.24
 */

namespace Uzduotys.Uzduotis8
{
    class Sprendimas
    {
        const double PI = 3.14;
        double spindulys;
        int skrituliai;

        public Sprendimas()
        {
            Console.WriteLine("Įveskite mažiausio skritulio spindulį:");
            bool rTryParse = Double.TryParse(Console.ReadLine(), out spindulys);
            while (rTryParse == false || spindulys <= 0)
            {
                Console.WriteLine("Neteisingai įvestas skritulio spindulys. Skritulio spindulys turi būti teigiamas skaičius ir didesnis už 0.");
                Console.WriteLine("Įveskite mažiausio skritulio spindulį:");
                rTryParse = Double.TryParse(Console.ReadLine(), out spindulys);
            }

            Console.WriteLine("Įveskite skritulių kiekį:");
            bool skrituliaiTryParse = Int32.TryParse(Console.ReadLine(), out skrituliai);
            while (skrituliaiTryParse == false || skrituliai <= 0)
            {
                Console.WriteLine("Neteisingai įvestas skritulių kiekis. Skritulių kiekis turi būti sveikasis skaičius ir didesnis už 0.");
                Console.WriteLine("Įveskite skritulių kiekį:");
                skrituliaiTryParse = Int32.TryParse(Console.ReadLine(), out skrituliai);
            }

            GautiAtsakyma();
        }

        private double SkaiciuotiSkritulioPlota(double pi, double spindulys, int nSkritulys)
        {
            int daugiklis = 1 * (int)Math.Pow(2, nSkritulys);
            
            return Math.Pow(spindulys * daugiklis, 2) * pi;
        }

        private void GautiAtsakyma()
        {
            Console.WriteLine("Skrituliai: {0}", skrituliai);
            for (int i = 0; i < skrituliai; i++)
            {
                Console.WriteLine("{0} Skritulio Plotas: {1}", i + 1, SkaiciuotiSkritulioPlota(PI, spindulys, i));
            }
        }
    }
}
