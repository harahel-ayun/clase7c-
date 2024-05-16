using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8
{
    internal class Program
    {
        static void Main(string[] args)
        {   int ni = 0;   
            int nf = 0;
            bool esprimo = false;   
            Console.WriteLine("Escriba intervalo");
            ni = Convert.ToInt32(Console.ReadLine());
            nf = Convert.ToInt32(Console.ReadLine());
            for (int i = ni; i<= nf; i++) {
                int num, cont;

                num = i;
                cont = 0;
                
                {
                    for (int n = 1; n <= num; n++)
                    {
                        if (num % n == 0)
                        {
                            cont++;

                        }
                        else { }
                    }
                      esprimo = false;
                    if (cont == 2)
                        
                    {
                        esprimo = true;
                    }
                    else
                    {
                        esprimo= false; 
                    }
                    if (esprimo == true)
                    { Console.WriteLine("es primo {0}", num); }
                    else {}
                        
                    Console.ReadKey();

                }
            }

            
        }
    }
}