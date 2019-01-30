using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" datos conocidos w, t, c, encontrar x");

            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine()); // Grados


        

            double z = t * Math.Sin(c * (Math.PI / 180)); // pasar a radianes 

            // Pitagoras para y 

            double y = Math.Sqrt(Math.Pow(t, 2) - Math.Pow(z, 2));

            // pitagoras a el secmento xy

            double xy = Math.Sqrt(Math.Pow(w, 2) - Math.Pow(z, 2));

            // hallar x

            double x = xy - y;


            // Salidas 

            Console.WriteLine("z:" + z);
            Console.WriteLine("y:" + y);
            Console.WriteLine("xy:" + xy);
            Console.WriteLine(" la respuesta es de x:" + x);
        }
    }
}
