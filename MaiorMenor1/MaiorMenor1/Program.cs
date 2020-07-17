using System;

namespace MaiorMenor
{
    class Program
    {


        static Double MaiorValor(Double[] v, int tl)
        {

            Double maior = v[0];
            int i = 0;
            for (i = 1; i < tl; i++)
            {
                if (maior < v[i])
                {
                    maior = v[i];
                }
               
            }
            return maior;
        }

        static Double MenorValor(Double[] v, int tl)
        {

            Double menor = v[0];
            int i = 0;
            for (i = 1; i < tl; i++)
            {
                if (menor > v[i])
                {
                    menor = v[i];
                }

            }
            return menor;
        }
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

                maior = MaiorValor(valores, tl);
                menor = MenorValor(valores, tl);
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

