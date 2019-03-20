using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            metodo1 mt1 = new metodo1();
            mt1.multi();

            metodo2 mt2 = new metodo2();
            mt2.divi();

            metodo3 mt3 = new metodo3();
            mt3.nombres();

            
            Console.ReadKey();
        }
    }
}
