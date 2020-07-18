using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, r = 0, cont=0;
;
            Console.WriteLine("Número Primos");
            Console.Write("Informe um número: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i >0; i--)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }

            if (cont==2)
            {
                Console.WriteLine("O número " + n + " é um número primo.");

            }
            else
            {
                Console.WriteLine("O número " + n + " não é número primo.");
            }

            Console.ReadKey();
        }
    }
}
