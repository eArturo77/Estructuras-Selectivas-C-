using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double notateoria, notapracticas,notafinal;
            string calificacion;
            Console.WriteLine("Ingrese la nota de la teoria");
            notateoria = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de las practicas");
            notapracticas = double.Parse(Console.ReadLine());

            notafinal = (notateoria * 0.6) + (notapracticas * 0.4);



            if (notafinal >= 9)
            {
                calificacion = "sobresaliente";
            }
            else if (notafinal >= 7)
            {
                calificacion = "Notable";
            }
            else if (notafinal > 5)
            {
                calificacion = "Aprobado";
            }
            else 
            {
                calificacion = "suspenso";
            }
            Console.WriteLine($"La nota final es: {notafinal}");
            Console.WriteLine($"Calificacion {calificacion}");

            

        }
    }
}
