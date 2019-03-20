using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace parcial2
{
    class metodo1
    {
        public void multi()
        {
            int n1 = 0, n2 = 0, n3 = 0;
            Console.WriteLine("Selecione Menu");
            Console.WriteLine("1. Multiplicar");

            int mul;
            mul = Convert.ToInt32(Console.ReadLine());

            switch (mul)
            {
                case 1:
                    {
                        Console.WriteLine("Ingrese el Primer Numero");
                        n1 = int.Parse(Console.ReadLine());

                        if (n1 == 0)
                            Console.WriteLine("El Producto de 0 por cualquier numero es 0");
                        else
                            Console.WriteLine("Ingrese el segundo  Numero");
                        n2 = int.Parse(Console.ReadLine());
                        n3 = n1 * n2;
                        Console.WriteLine("El resultado de la operacion es: " + n3);

                    }
                    break;

            }

        }
    }
}
