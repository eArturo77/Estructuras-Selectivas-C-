using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2__Estructuras_Selectivas
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
            double numero;
            Console.WriteLine("Escriba cuanto vale el numero");
            numero = double.Parse(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else 
            {
                Console.WriteLine("El numero es negativo");
            }
      
            Console.ReadKey();
        }
    }
}
