using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar1
{
    class Program
    {
        public static Boolean numeroPar(int num)
        {
            Boolean retorno = false;
            if (num % 2 == 0) retorno = true;
            return retorno;
        }
        static void Main(string[] args)
        {
            int n = 0;
            Boolean par = false;

            String op = "s";

            while (op == "s")
            {
                Console.Clear();
                Console.WriteLine("Verificar se o número informado é par ou impar");
                Console.Write("Informe um número: ");
                n = Convert.ToInt32(Console.ReadLine());
                par = numeroPar(n);
                if (par == true)
                {
                    Console.WriteLine("O número informado é par");
                }
                else
                {
                    Console.WriteLine("O número informado é impar");
                }
                op = "x";
                while ((op != "s") && (op != "n"))
                {
                   
                    Console.Write("Deseja verificar outro  número s/n: ");
                    op = Console.ReadLine();
                    op = op.ToLower();
          
                }
            }

        }
    }
}
