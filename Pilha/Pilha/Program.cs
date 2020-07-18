using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Program
    {
        static Boolean Empilhar(int[] pilha, ref int topo, int dado)
        {
            Boolean retorno = false;
            if (topo<10)
            {
                pilha[topo] = dado;
                topo = topo + 1;
                retorno = true;
            }
            return retorno;

           
        }

        static Boolean Desempilhar(int[] pilha, ref int topo, ref int dado)
        {
            Boolean retorno = false;
            if (topo > 0)
            {
                topo = topo - 1;
                dado = pilha[topo];
                retorno = true;
            }
            return retorno;
        }
          static void Main(string[] args)
            {

            }
    }
}
