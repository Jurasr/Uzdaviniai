using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Parašykite programą, kuri suskaičiuotų stačiakampio, kurio viršutinio kairiojo
 * taško (x1;y1) ir apatino dešiniojo taško (x2;y2) coordinates sveikieji skaičiai,
 * plotą s ir perimetrą p. Stačiakampio kraštinės lygiagrečios koordinačių ašims.
 * Pvz.: x1=0, y1=5, x2=4, y2=0, tai s=20 ir p=18.
 */

namespace Uzduotys.Uzduotis7
{
    class Sprendimas
    {
        (int x, int y) T1;
        (int x, int y) T2;

        public Sprendimas()
        {
            Console.WriteLine("Įveskite pirmojo taško X kordinatę");
            bool T1XTryParse = Int32.TryParse(Console.ReadLine(), out T1.x);
            while (T1XTryParse == false || T1.x < 0)
            {
                Console.WriteLine("Neteisingai įvestas skaičius - skaičius turi būti sveikasis skaičius ir didesnis už arba lygus 0");
                Console.WriteLine("Įveskite pirmojo taško X kordinatę");
                T1XTryParse = Int32.TryParse(Console.ReadLine(), out T1.x);
            }

            Console.WriteLine("Įveskite pirmojo taško Y kordinatę");
            bool T1YTryParse = Int32.TryParse(Console.ReadLine(), out T1.y);
            while (T1YTryParse == false || T1.y < 0)
            {
                Console.WriteLine("Neteisingai įvestas skaičius - skaičius turi būti sveikasis skaičius ir didesnis už arba lygus 0");
                Console.WriteLine("Įveskite pirmojo taško Y kordinatę");
                T1YTryParse = Int32.TryParse(Console.ReadLine(), out T1.y);
            }

            Console.WriteLine("Įveskite antrojo taško X kordinatę");
            bool T2XTryParse = Int32.TryParse(Console.ReadLine(), out T2.x);
            while (T2XTryParse == false || T2.x < 0)
            {
                Console.WriteLine("Neteisingai įvestas skaičius - skaičius turi būti sveikasis skaičius ir didesnis už arba lygus 0");
                Console.WriteLine("Įveskite antrojo taško X kordinatę");
                T2XTryParse = Int32.TryParse(Console.ReadLine(), out T2.x);
            }

            Console.WriteLine("Įveskite antrojo taško Y kordinatę");
            bool T2YTryParse = Int32.TryParse(Console.ReadLine(), out T2.y);
            while (T2YTryParse == false || T2.y < 0)
            {
                Console.WriteLine("Neteisingai įvestas skaičius - skaičius turi būti sveikasis skaičius ir didesnis už arba lygus 0");
                Console.WriteLine("Įveskite antrojo taško Y kordinatę");
                T2YTryParse = Int32.TryParse(Console.ReadLine(), out T2.y);
            }

            GautiAtsakyma();
        }

        private int SkaiciuotiPerimetra((int x, int y) t1, (int x, int y) t2)
        {
            return (t2.x - t1.x) * 2 + (t1.y - t2.y) * 2;
        }

        private int SkaiciuotiPlota((int x, int y) t1, (int x, int y) t2)
        {
            return (t2.x - t1.x) * (t1.y - t2.y);
        }

        private void GautiAtsakyma()
        {
            Console.WriteLine("Koordinate 1: ({0}, {1})", T1.x, T1.y);
            Console.WriteLine("Koordinate 2: ({0}, {1})", T2.x, T2.y);
            Console.WriteLine("Perimetras: {0}", SkaiciuotiPerimetra(T1, T2));
            Console.WriteLine("Plotas: {0}", SkaiciuotiPlota(T1, T2));
        }
    }
}
