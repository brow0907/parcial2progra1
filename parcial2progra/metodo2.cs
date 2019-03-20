using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2
{
    class metodo2
    {
        public void divi()
        {
            int n1 = 0, n2 = 0, n3 = 0;
            Console.WriteLine("Selecione otra opcion del  Menu");
            Console.WriteLine("2. Division");

            int div;
            div = Convert.ToInt32(Console.ReadLine());

            switch (div)
            {
                case 2:
                    {
                        Console.WriteLine("Ingrese el Primer Numero");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo  Numero");
                        n2 = int.Parse(Console.ReadLine());
                      

                        if (n2 == 0)
                            Console.WriteLine("Error no se puede divir entre 0");
                        else
                            
                         n3 = n1 / n2;
                        Console.WriteLine("El resultado de la operacion es: " + n3);

                    }
                    break;

            }

        }
    }
}
