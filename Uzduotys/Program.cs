using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Uzduotis
            /*
            Console.WriteLine("***** 1 Uzduotis *****");
            new Uzduotys.Uzduotis1.Uzduotis1().GautiAtsakyma();
            Console.WriteLine("**********************");
            
            */
            // 2 Uzduotis
            Console.WriteLine("**** 2 Uzduotis *****");
            new Uzduotys.Uzduotis2.Uzduotis2().GautiKaina();
            Console.WriteLine("*********************");
            

            Console.ReadLine();
        }
    }
}
