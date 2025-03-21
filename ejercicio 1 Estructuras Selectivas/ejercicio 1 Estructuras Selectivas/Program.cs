using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1_Estructuras_Selectivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///Arturo de Jesús Valencia Argueta
            ///20250272
            ///</summary>
            ///
            double numero1, numero2;
            Console.WriteLine("Ingrese el valor del primer numero");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo numero");
            numero2 = double.Parse(Console.ReadLine());
            if (numero1 > numero2) 
            {
                Console.WriteLine("El primer numero es mayor");
            }
            else 
            {
                Console.WriteLine("El primer numero es menor");
            }
            Console.ReadKey();
        }
    }
}
