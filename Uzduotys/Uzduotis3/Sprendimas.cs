using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Indėlininkas į banką padėjo suma litų. Bankas moka 2proc. metinių palūkanų.
 * Sudarykite programą dviejų metų apskaitai skaičiuoti. Ekrane išveskite
 * palūkanas ir turimą indėlį kasmet.
 */

namespace Uzduotys.Uzduotis3
{
    class Sprendimas
    {
        decimal indelis;
        decimal palukanos;
        int metai;

        public Sprendimas()
        {
            
            Console.WriteLine("Indėlis(LT):");
            Decimal.TryParse(Console.ReadLine(), out indelis);
            int SkaiciaiPoKablelioIndelis = BitConverter.GetBytes(decimal.GetBits(indelis)[3])[2];
            while(indelis <= 0 || SkaiciaiPoKablelioIndelis > 2)
            {
                Console.WriteLine("Netinkamas indėlis - indėlis turi būti didesnis už 0 ir turėti max 2 skaičius po kablelio.");
                Console.WriteLine("Indėlis(LT):");
                Decimal.TryParse(Console.ReadLine(), out indelis);
                SkaiciaiPoKablelioIndelis = BitConverter.GetBytes(decimal.GetBits(indelis)[3])[2];
            }

            Console.WriteLine("Metinės palūkanos(%):");
            Decimal.TryParse(Console.ReadLine(), out palukanos);
            while (palukanos <= 0)
            {
                Console.WriteLine("Netinkamos metinės palūkanos - metinės palūkanos turi būti didesnės už 0.");
                Console.WriteLine("Metinės palūkanos(%):");
                Decimal.TryParse(Console.ReadLine(), out palukanos);
            }

            Console.WriteLine("Indėlio laikymo terminas metais:");
            Int32.TryParse(Console.ReadLine(), out metai);
            while (metai <= 0)
            {
                Console.WriteLine("Neteisingai įvestas indėlio laikymo terminas. Indėlio laikymo terminas turi būti sveikasis skaičius ir didesnis už 0.");
                Console.WriteLine("Indėlio laikymo terminas metais:");
                Int32.TryParse(Console.ReadLine(), out metai);
            }

            GautiAtsakyma();
        }


        private void GautiAtsakyma()
        {
            Console.WriteLine("Jūsų padėtas indėlis yra {0} LT, metinės palūkanos: {1}%", indelis, palukanos);
            for (int i = 1; i <= metai; i++)
            {
                Console.WriteLine("Po {0} metų jūsų indėlis bus vertas {1} LT", i, SkaiciuotiIndeli(indelis, palukanos, i));
            }
        }


        private double SkaiciuotiIndeli(decimal indelis, decimal palukanos, int metai)
        {
            return Math.Round((double)indelis * Math.Pow(1 + (double)palukanos / 100, metai), 2);
        }
    }
}
