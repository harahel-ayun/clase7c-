using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generar_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cont;
            Console.WriteLine("Ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            cont = 0;
            if (num < 4)
            {
                Console.WriteLine("el numero es primo");
                Console.ReadKey();
            }
            else
            {
                for (int n = 1; n <= num; n++)
                {
                    if (num % n == 0)
                    {
                        cont++;
                        
                    }
                    else { }
                }
                if (cont == 2
                    )
                {
                    Console.WriteLine("Es primo");
                }
                else
                {
                    Console.WriteLine("no es primo");
                }
                Console.ReadKey();

            }
        }
    }
}
