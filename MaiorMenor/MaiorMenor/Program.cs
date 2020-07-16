using System;

namespace MaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, menor, i = 0, numero = 0, tl = 0;
            Console.WriteLine("Determina o maior e o menor número informado pelo usúario.");
            Console.Write("Deseja informar quantos números?: ");
            tl = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Informe o 1 número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            maior = numero;
            menor = numero;
            for ( i = 2; i <=tl; i++)
            {
                Console.Write(" Informe o "+i+" número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < menor)
                {
                    menor = numero;
                }
                if (numero > maior)
                {
                    maior = numero;
                }
            }
            Console.WriteLine("O maior é "+maior+ " e o menor e "+menor);
            Console.ReadKey();
        }
    }
}
