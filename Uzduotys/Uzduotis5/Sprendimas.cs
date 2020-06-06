using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Parašykite programą, kuri suskaičiuotų, kiek knygų k vidutiniškai per metus
 * perskaito vienas mokyklos bibliotekos lankytojas. Žinomas vidutiniškai per
 * mėnesį perskaitytų knygų skaičius v ir vidutiniškai per metus apsilankiųsių
 * bibliotekoje skaičius n.
 */

namespace Uzduotys.Uzduotis5
{
    class Sprendimas
    {
        double vidKnyguPerMenesi;
        double vidLankytojuPerMetus;
        double vidKnyguPerMetus;

        // k - vid knygu per metus per viena lankytoja?
        // v - total month read books
        // n - total visitors per year
        public Sprendimas()
        {
            Console.WriteLine("Įveskite skaičių, kiek vidutiniškai per mėnesį lankytojai perskaito knygų:");
            Double.TryParse(Console.ReadLine(), out vidKnyguPerMenesi);
            while (vidKnyguPerMenesi <= 0)
            {
                Console.WriteLine("Neteisingai įvestas vidutiniškai perskaitytų knygų kiekis. Vidutiniškai perskaitytų knygų kiekis turi būti didesnis už 0.");
                Console.WriteLine("Įveskite skaičių, kiek vidutiniškai per mėnesį lankytojas perskaito knygų:");
                Double.TryParse(Console.ReadLine(), out vidKnyguPerMenesi);
            }

            Console.WriteLine("Įveskite skaičių, kiek vidutiniškai per metus lankytojų apsilanko bibliotekoje:");
            Double.TryParse(Console.ReadLine(), out vidLankytojuPerMetus);
            while (vidLankytojuPerMetus <= 0)
            {
                Console.WriteLine("Neteisingai įvestas vidutiniškai perskaitytų knygų kiekis. Vidutiniškai perskaitytų knygų kiekis turi būti didesnis už 0.");
                Console.WriteLine("Įveskite skaičių, kiek vidutiniškai per mėnesį lankytojas perskaito knygų:");
                Double.TryParse(Console.ReadLine(), out vidLankytojuPerMetus);
            }

            GautiAtsakyma();
        }

        private void GautiAtsakyma()
        {
            Console.WriteLine("Vid. knygų perskaitytą per metus: {0}", vidKnyguPerMenesi * 12);
            Console.WriteLine("Vid. lankytojų per metus: {0}", vidLankytojuPerMetus);
            Console.WriteLine("Vid. kiek knygų perskaito vienas lankytojas: {0}", vidKnyguPerMenesi * 12 / vidLankytojuPerMetus);

        }
    }
}
