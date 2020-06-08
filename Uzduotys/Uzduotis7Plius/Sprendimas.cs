using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Parašykite programą, kuri priimtu dviejų taškų koordinačių informaciją iš vartotojo. 
 * Iš duotų dviejų taškų turi susidaryti horizontalus stačiakampis. 
 * Apskaičiuokite plotą ir perimetrą.
 * 
 * Taškų koordinatės - teigiami sveikieji skaičiai.
 */

namespace Uzduotys.Uzduotis7Plius
{
    class Sprendimas
    {
        (int X, int Y) A;
        (int X, int Y) D;
        int a;
        int b;

        public Sprendimas()
        {
            PrintStaciakampi();

            // A Taskas
            Console.WriteLine("Įveskite A taško X koordinatę.");
            bool AXTryParse = Int32.TryParse(Console.ReadLine(), out A.X);
            while (!AXTryParse || A.X < 0)
            {
                Console.WriteLine("Neteisingai įvestas skaičius - skaičius turi būti sveikasis ir didesnis už 0.");
                Console.WriteLine("Įveskite A taško X koordinatę.");
                AXTryParse = Int32.TryParse(Console.ReadLine(), out A.X);
            }

            Console.WriteLine("Įveskite A taško Y koordinatę.");
            bool AYTryParse = Int32.TryParse(Console.ReadLine(), out A.Y);
            while (!AYTryParse || A.Y < 1)
            {
                Console.WriteLine("Neteisingai įvestas skaičius - skaičius turi būti sveikasis ir didesnis už 1.");
                Console.WriteLine("Įveskite A taško Y koordinatę.");
                AYTryParse = Int32.TryParse(Console.ReadLine(), out A.Y);
            }

            // D Taskas
            Console.WriteLine("Įveskite D taško X koordinatę.");
            Console.WriteLine("D taško X koordinatė turi būti teigiamas sveikasis skaičius ir didesnis uz {0}", A.Y);
            bool DXTryParse = Int32.TryParse(Console.ReadLine(), out D.X);
            while (!DXTryParse || D.X <= A.Y)
            {
                Console.WriteLine("D taško X koordinatė turi būti teigiamas sveikasis skaičius ir didesnis už {0}", A.Y);
                Console.WriteLine("Įveskite D taško X koordinatę.");
                DXTryParse = Int32.TryParse(Console.ReadLine(), out D.X);
            }

            Console.WriteLine("Įveskite D taško Y koordinatę.");
            Console.WriteLine("D taško Y koordinatė turi būti teigiamas sveikasis skaičius ir mazesnis už {0}", A.Y);
            bool DYTryParse = Int32.TryParse(Console.ReadLine(), out D.Y);
            while (!DYTryParse || D.Y >= A.Y)
            {
                Console.WriteLine("D taško Y koordinatė turi būti teigiamas sveikasis skaičius ir mazesnis už {0}", A.Y);
                Console.WriteLine("Įveskite D taško Y koordinatę.");
                DYTryParse = Int32.TryParse(Console.ReadLine(), out D.Y);
            }

            (a, b) = GautiKrastiniuIlgius();
            GautiAtsakyma();
        }

        private void PrintStaciakampi()
        {
            Console.WriteLine();
            Console.WriteLine(" A ____________ B");
            Console.WriteLine("  |            |");
            Console.WriteLine("  |____________|");
            Console.WriteLine(" C              D");
            Console.WriteLine();
            Console.WriteLine();
        }

        private (int a, int b) GautiKrastiniuIlgius()
        {

            return (D.X - A.X, A.Y - D.Y);
        }

        private int ApskaiciuotiPerimetra((int a, int b) krastines)
        {
            return krastines.a * 2 + krastines.b * 2;
        }

        private int ApskaiciuotiPlota((int a, int b) krastines)
        {
            return krastines.a * krastines.b;
        }

        private void GautiAtsakyma()
        {
            PrintStaciakampi();

            Console.WriteLine("Taskai:");
            Console.WriteLine("A: ({0}, {1})", A.X, A.Y);
            Console.WriteLine("B: ({0}, {1})", D.X, A.Y);
            Console.WriteLine("C: ({0}, {1})", A.X, D.Y);
            Console.WriteLine("D: ({0}, {1})", D.X, D.Y);
            Console.WriteLine();

            Console.WriteLine("Krastines:");
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);

            Console.WriteLine("Perimetras: {0}", ApskaiciuotiPerimetra((a,b)));
            Console.WriteLine("Plotas: {0}", ApskaiciuotiPlota((a,b)));
        }
    }
}
