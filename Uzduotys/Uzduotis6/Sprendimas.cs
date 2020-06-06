using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Parašykite programą, kuri suskaičiuotų, kiek vidutiniškai keleivių k važiuoja į
 * Vilnių viename traukinio vagone, jei žinomas traukinio keleivių skaičius n,
 * keleivių, vykstančių ne į Vilnių skaičius m ir vagonų skaičius v. Pvz.: n=100,
 * m=20 ir v=4, tai k=20.
 */

namespace Uzduotys.Uzduotis6
{
    class Sprendimas
    {
        int keleiviaiPerTraukini;
        int keleiviaiNeIVilniu;
        int vagonai;

        public Sprendimas()
        {
            Console.WriteLine("Kiek keleivių važiuoja traukinyje?");
            Int32.TryParse(Console.ReadLine(), out keleiviaiPerTraukini);
            while (keleiviaiPerTraukini <= 0)
            {
                Console.WriteLine("Neteisingai įvestas keleivių skaičius. Skaičius turi būti sveikasis skaičius ir didesnis už 0.");
                Int32.TryParse(Console.ReadLine(), out keleiviaiPerTraukini);
            }

            Console.WriteLine("Kiek keleivių važiuoja ne į Vilnių traukinyje?");
            Int32.TryParse(Console.ReadLine(), out keleiviaiNeIVilniu);
            while (keleiviaiPerTraukini <= 0 || keleiviaiNeIVilniu > keleiviaiPerTraukini)
            {
                Console.WriteLine("Neteisingai įvestas keleivių važiuojančių ne į Vilnių skaičius. Skaičius turi būti sveikasis skaičius, didesnis už 0 ir mažesnis už visų keleivių skaičių.");
                Int32.TryParse(Console.ReadLine(), out keleiviaiNeIVilniu);
            }

            Console.WriteLine("Kiek vagonų yra traukinyje?");
            Int32.TryParse(Console.ReadLine(), out vagonai);
            while (vagonai <= 0 || vagonai > 100)
            {
                Console.WriteLine("Neteisingai įvestas vagonų skaičius. Skaičius turi būti sveikasis skaičius, didesnis už 0 ir ne didesnis už 100.");
                Int32.TryParse(Console.ReadLine(), out keleiviaiNeIVilniu);
            }

            GautiAtsakyma();
        }

        private double apskaiciuotiVidKeleiviusPerVagonaIVilniu()
        {
            return (keleiviaiPerTraukini - keleiviaiNeIVilniu) / vagonai;
        }

        private void GautiAtsakyma()
        {
            Console.WriteLine("Viso keleiviai: {0}", keleiviaiPerTraukini);
            Console.WriteLine("Viso keleiviai važiuojantys ne į Vilnių: {0}", keleiviaiNeIVilniu);
            Console.WriteLine("Viso vagonai: {0}", vagonai);
            Console.WriteLine("Vidutiniškai keleivių, važiuojančių į Vilnių, viename vagone: {0}", apskaiciuotiVidKeleiviusPerVagonaIVilniu());
        }
    }
}
