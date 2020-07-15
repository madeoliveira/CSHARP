using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0, c=0;
            String msg = "Não representam os lados de um triângulo.";

            Console.WriteLine("Verifica se três valores informados representam os dados de um triângulo.");
            Console.Write("Informe o valor do lado A do triângulo: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o valor do lado B do triângulo: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o valor do lado C do triângulo: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b + c)
            {
                if (b < a + c)
                {
                    if (c < b + c)
                    {
                        msg = "Representam os lados de um triãngulo. ";
                    }
                }
            }
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
