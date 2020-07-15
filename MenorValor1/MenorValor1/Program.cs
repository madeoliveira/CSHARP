using System;

namespace MaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, menor = 0, n = 0;
            Console.WriteLine("Determina o menor valor. \n");
            Console.Write("Informe o " + i + " valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            menor = n;

            while (i <= 9)
            {
                i += 1;


                Console.Write("Informe o " + i + " valor: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (menor > n)
                {
                    menor = n;
                }


            }
            Console.WriteLine("\nO menor valor informado é : " + menor);
            Console.ReadLine();
        }
    }
}