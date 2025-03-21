using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///Arturo de Jesús Valencia Argueta
            ///20250272
            ///</summary>
            ///
            double a, b, c;
            Console.Write("Introduce la longitud del primer lado: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Introduce la longitud del segundo lado: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Introduce la longitud del tercer lado: ");
            c = double.Parse(Console.ReadLine());


            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Sí, se puede formar un triángulo Equilátero.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Sí, se puede formar un triángulo Isósceles.");
                }
                else
                {
                    Console.WriteLine("Sí, se puede formar un triángulo Escaleno.");
                }
            }
            else
            {
                Console.WriteLine("No se puede formar un triángulo con estas longitudes.");
            }

        }

    }
}
    

