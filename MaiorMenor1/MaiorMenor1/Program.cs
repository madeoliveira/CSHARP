using System;

namespace MaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, tl = 0;
            Double maior = 0, menor = 0;
            Double[] valores = new double[100];

            Console.WriteLine("Determina o maior e o menor número informado pelo usúario.");
            Console.Write("Deseja informar quantos números?: ");
            tl = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < tl; i++)
            {
                Console.Write("Informar o número: ");
                valores[i] = Convert.ToDouble(Console.ReadLine());
            }
            i = 0;
            if (tl > 0)
            {
                maior = valores[0];
                menor = valores[0];
                for (i = 1; i < tl; i++)
                {
                    if (maior < valores[i])
                    {
                        maior = valores[i];
                    }
                    if(menor > valores[i])
                    {
                        menor = valores[i];
                    }
                }

            }
            else
            {
                Console.WriteLine(" Nenhum valor foi informado pelo usuário");
            }
            Console.WriteLine(" Maior valor: "+ maior+" Menor valor: "+menor);
            Console.ReadLine();
        }
    }
}

