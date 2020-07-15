using System;

namespace MenorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maior = 0;
            Console.WriteLine("Determina o menor valor");
            Console.Write("Informe o rimeiro valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            maior = n;
            Console.Write("Informe o segundo valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < maior)
            {
                maior = n;
            }
            Console.Write("Informe o terceiro valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < maior)
            {
                maior = n;
            }
            Console.Write("Informe o quarto valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < maior)
            {
                maior = n;
            }
            Console.WriteLine("O menor valor informado é : " + maior);
            Console.ReadLine();
        }
    }
}

