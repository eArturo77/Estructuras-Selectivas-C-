using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
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
            double numero1, numero2, numero3;
            Console.WriteLine("Ingrese el primer numero");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            numero3 = double.Parse(Console.ReadLine());
            if (numero1 < numero2 && numero2 < numero3)
            {
                Console.WriteLine("Ordenados de manera ascendente");
            }
            else if (numero1 > numero2 && numero2 > numero3)
            {
                Console.WriteLine("Ordenados de manera descendente");
            }
            else
            {
                Console.WriteLine("Desordenados");
            }

        }
    }
}
