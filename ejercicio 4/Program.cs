using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
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
            double notaExamenFinal, notaParciales, notaPracticas, mediaPonderada,notaFinal;

            Console.WriteLine("Ingrese la nota del examen final");
            notaExamenFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de los Examenes Parciales");
            notaParciales = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de las practicas");
            notaPracticas = double.Parse(Console.ReadLine());

            mediaPonderada = (notaExamenFinal * 0.4) + (notaParciales * 0.4) + (notaPracticas * 0.2);
            if (notaExamenFinal >= 4 && notaParciales >= 4 && notaPracticas >= 4)
            {
                notaFinal = mediaPonderada;
            }
            else
            {
                notaFinal = Math.Min(4, mediaPonderada);
            }
            Console.WriteLine($"La nota final del estudiante es: {notaFinal:F2}");
        }

    }
    }






