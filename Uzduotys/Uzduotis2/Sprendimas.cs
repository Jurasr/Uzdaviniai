using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Žinomi kambario matmenys –ilgis ir plotis. Abu dydžiai sveikieji skaičiai. Reikia
 * apskaičiuoti, kokią pinigų sumą reiks mokėti už plyteles, skirtas kambario
 * grindims kloti, jei plytelių vieno kvadrato kaina yra kaina litų. Plytelių reikia
 * pirkti 5 proc. daugiau galimiems nuostoliams padengti.
 */

namespace Uzduotys.Uzduotis2
{
    class Sprendimas
    {
        decimal KambarioIlgis;
        decimal KambarioPlotis;
        decimal PlyteliuKaina;
        decimal NuostoliaiProc;

        public Sprendimas()
        {
            
            Console.WriteLine("Kambario ilgis(m):");
            Decimal.TryParse(Console.ReadLine(), out KambarioIlgis);
            while (KambarioIlgis <= 0)
            {
                Console.WriteLine("Neteisingai įvestas kambario ilgis. Kambario ilgis turi būti didesnis už 0.");
                Console.WriteLine("Kambario ilgis(m):");
                Decimal.TryParse(Console.ReadLine(), out KambarioIlgis);
            }

            Console.WriteLine("Kambario plotis(m):");
            Decimal.TryParse(Console.ReadLine(), out KambarioPlotis);
            while (KambarioPlotis <= 0)
            {
                Console.WriteLine("Neteisingai įvestas kambario plotis. Kambario plotis turi būti didesnis už 0.");
                Console.WriteLine("Kambario plotis(m):");
                Decimal.TryParse(Console.ReadLine(), out KambarioPlotis);
            }

            Console.WriteLine("Plytelių kaina(EUR):");
            Decimal.TryParse(Console.ReadLine(), out PlyteliuKaina);
            int SkaiciaiPoKablelioPlyteliuKaina = BitConverter.GetBytes(decimal.GetBits(PlyteliuKaina)[3])[2];
            while (PlyteliuKaina <= 0 || SkaiciaiPoKablelioPlyteliuKaina > 2)
            {
                Console.WriteLine("Neteisingai įvesta plytelių kaina. Plytelių kaina turi būti didesnė už 0 ir turėti max 2 skaičius po kablelio.");
                Console.WriteLine("Plytelių kaina(EUR):");
                Decimal.TryParse(Console.ReadLine(), out PlyteliuKaina);
                SkaiciaiPoKablelioPlyteliuKaina = BitConverter.GetBytes(decimal.GetBits(PlyteliuKaina)[3])[2];
            }
           

            Console.WriteLine("Nuostoliu padengimas(proc):");
            bool TryParseNuostoliaiProc = Decimal.TryParse(Console.ReadLine(), out NuostoliaiProc);
            while ((NuostoliaiProc < 0 || NuostoliaiProc > 100) || (NuostoliaiProc == 0 && TryParseNuostoliaiProc == false))
            {
                Console.WriteLine("Neteisingai įvestas nuostolių procentas. Nuostolių procentas turi būti tarp 0 ir 100 .");
                Console.WriteLine("Nuostoliu padengimas(proc):");
                TryParseNuostoliaiProc = Decimal.TryParse(Console.ReadLine(), out NuostoliaiProc);
            }

            GautiAtsakyma();
        }

        private decimal GautiKaina()
        {
            return Math.Round(KambarioIlgis * KambarioPlotis * PlyteliuKaina * (1 + NuostoliaiProc / 100), 2);
        }

        private void GautiAtsakyma()
        {
            Console.WriteLine("Kambario Ilgis: {0}m, Kambario Plotis: {1}m, Nuostolių Padengimas: {2}%, Viso Kaina: {3} EUR.", KambarioIlgis, KambarioPlotis, NuostoliaiProc, GautiKaina());
        }
    }
}
