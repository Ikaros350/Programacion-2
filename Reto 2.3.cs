using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
          

                Console.WriteLine(" datos conocidos w, d, x, encontrar y");

                double w = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                double x = double.Parse(Console.ReadLine());


                // hallar el secmento xy de la suma de x (valor conocido), y 

                double xy = w * Math.Cos(d * (Math.PI / 180)); // Pasar a radianes

                // Ahora usar encontramos a y 

                double y = xy - x;


                Console.WriteLine("xy:" + xy);
                Console.WriteLine("el valor de y:" + y);

            }
        }

    }


