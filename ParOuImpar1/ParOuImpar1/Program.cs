﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0,r=0;
            String op = "s";

            while (op == "s")
            {
                Console.Clear();
                Console.WriteLine("Verificar se o número informado é par ou impar");
                Console.Write("Informe um número: ");
                n = Convert.ToInt32(Console.ReadLine());
                r = n % 2;
                if (r == 0)
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
