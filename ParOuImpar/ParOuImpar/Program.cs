using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, r = 0;
            Console.WriteLine("Verificar se o número informado é par ou impar");
            Console.Write("Informe um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            r = n % 2;
            if(r ==0 )
            {
                Console.WriteLine("O número informado é par");
            }
            else
            {
                Console.WriteLine("O número informado é impar");

            }
            Console.ReadKey();
        }
    }
}
