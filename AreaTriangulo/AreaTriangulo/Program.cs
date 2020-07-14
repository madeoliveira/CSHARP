using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTri = 0, alturaTri = 0;

            Console.WriteLine("Calcular a área de um triângulo");
            Console.Write("Informe as base do triângulo: ");
            baseTri = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a altura do triângulo: ");
            alturaTri = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Área = " + ((baseTri * alturaTri) / 2));
            Console.ReadKey();

        }
    }
}
