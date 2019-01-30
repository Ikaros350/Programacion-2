using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" datos conocidos b, z, y, encontrar x");

            // b= 19.44° z= 3 y= 2

            double b = double.Parse(Console.ReadLine()); //Grados
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            // pitagoras 
            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));

            double a = Math.Acos(((t * t) + (z * z) - (y * y)) / (2 * t * z)) * (180 / Math.PI);
            double c = (180 - 90 - a); //grados

            //Conocemos b

            double ab = a + b; // la suma de los dos angulos para hacer el angulo del tercer triangulo

            double d = 180 - 90 - ab;

            // procedo a hallar xy=x+y

            double xy = z / Math.Tan(d * (Math.PI / 180)); //tranformar en radianes, por que el probrama esta en radianes 

            // HALLAR y con (x = xy-y)

            double x = xy - y;

            // Salidas

            Console.WriteLine("t: " + t);
            Console.WriteLine("a:" + a);
            Console.WriteLine("c: " + c);
            Console.WriteLine("ab: " + ab);
            Console.WriteLine("d:" + d);
            Console.WriteLine("xy:" + xy);

            // Salida del problema 
            Console.WriteLine("x=" + x);
        }
    }
}
