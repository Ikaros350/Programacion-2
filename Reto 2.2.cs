using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" datos conocidos d, b, y, encontrar z");

            double d = double.Parse(Console.ReadLine());//grados
            double b = double.Parse(Console.ReadLine());//grados
            double y = double.Parse(Console.ReadLine());

            //Hallar e con suma de angulos 

            double e = 180 - d - b;

            // una recta de 180 se crea entre el lado y que conocemos y x el cual no, entonces con el angulo e que conocemos ya podemos hallar c

            double c = 180 - e;

            // ahora podemos hallar z con tangente ya que conocemos c y "y"

            double z = y * Math.Tan(c * (Math.PI / 180)); // convertir a radianes por que el sistema fuenciona en radianes 

            // Salidas 

            Console.WriteLine("e:" + e);
            Console.WriteLine("c:" + c);
            Console.WriteLine(" la respuesta es de z:" + z);

        }
    }
}
