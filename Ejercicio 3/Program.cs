using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
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
            double numero1, numero2, resultado;
            string operacion;
            Console.WriteLine("Ingrese el primer numero");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese que quiere hacer (suma, resta, multiplicacion, division)");
            operacion = Console.ReadLine();

            resultado = 0;
            if (operacion == "suma")
            {
                resultado = numero1 + numero2;
                Console.WriteLine($"El resultado de la suma es: {resultado}");
            }

            else if (operacion == "resta")
            {
                resultado = numero1 - numero2;
                Console.WriteLine($"El resultado de la resta es:{resultado}");
            }
            else if (operacion == "multiplicacion")
            {
                resultado = numero1 * numero2;
                Console.WriteLine($"El resultado de la multiplicacion es: {resultado}");
            }
            else if (operacion == "division")
            {
                resultado = numero1 / numero2;
                Console.WriteLine($"El resultado de la division es: {resultado}");
            }
            if (numero2 != 0)
            {
                Console.WriteLine($"Error {resultado}");
            }
            else
            {
                Console.WriteLine("Error no se puede operar con 0"); 
            }
            Console.WriteLine("Presiona Cualquier tecla :)");
            





                Console.ReadKey();
            
        }
        
    }
}
