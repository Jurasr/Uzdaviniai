using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Parašykite programą, kuri apskaičiuotų, kiek popieriaus lapų k reikės norint
 * nukopijuoti konspektą visos klasės mokiniams. Žinoma kad klasėje yra m
 * mokinių o konspektą sudaro n lapų. Pvz.: m=20, n=10, tai atsakymas 200.
 */

namespace Uzduotys.Uzduotis1
{
    class Uzduotis1
    {
        int Mokiniai;
        int KonspektoLapai;

        public Uzduotis1()
        {
            Console.WriteLine("Mokinių kiekis:");
            Int32.TryParse(Console.ReadLine(), out Mokiniai);
            while (Mokiniai <= 0)
            {
               Console.WriteLine("Neteisingai įvestas mokinių kiekis. Mokinių kiekis turi būti sveikasis skaičius ir didesnis už arba lygus 1.");
               Console.WriteLine("Mokinių kiekis:");
               Int32.TryParse(Console.ReadLine(), out Mokiniai);
            }

            Console.WriteLine("Lapų per konspektą kiekis:");
            Int32.TryParse(Console.ReadLine(), out KonspektoLapai);
            while (KonspektoLapai <= 0)
            {
                Console.WriteLine("Neteisingai įvestas lapų per konspektą kiekis. Lapų per konspektą kiekis turi būti sveikasis skaičius ir didesnis už arba lygus 1.");
                Console.WriteLine("Lapų per konspektą kiekis:");
                Int32.TryParse(Console.ReadLine(), out KonspektoLapai);
            }
        }

        public int GautiLapus()
        {
            return Mokiniai * KonspektoLapai;
        }

        public void GautiAtsakyma()
        {
            Console.WriteLine("Mokinių: {0}, Lapų per konspektą: {1}, Reikės iš viso lapų: {2}.", Mokiniai, KonspektoLapai, GautiLapus());
        }
    }
}
