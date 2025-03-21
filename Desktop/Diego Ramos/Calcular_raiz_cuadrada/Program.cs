using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_raiz_cuadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, raiz;
            Console.WriteLine("Ingrese el número de que desea saber la raíz");
            num = double.Parse(Console.ReadLine());
            raiz = Math.Sqrt(num);
            Console.WriteLine("La raíz cuadrada del número es: {0}", raiz);
            Console.ReadKey();
        }
    }
}
