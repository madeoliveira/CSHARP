using System;

namespace MaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, maior = 0, n=0; 
            Console.WriteLine("Determina o maior valor. \n");
            Console.Write("Informe o " +i+" valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            maior = n;
           
            while (i <= 9)
            {
                i += 1;
                
               
               Console.Write("Informe o " + i +" valor: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (maior < n)
                {
                    maior = n;
                }

               
            }
            Console.WriteLine("\nO maior valor informado é : "+maior);
            Console.ReadLine();
        }
    }
}