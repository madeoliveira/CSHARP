using System;

namespace CalculoComRaio
{
    class Program
    {
        static Double calculaDiametro(Double r)
        {
            Double retorno = 2 * r;
            return retorno;
        }
        static Double calculaArea(Double r)
        {
            return 3.14 * (r * r);
        }
        static Double calculaCircunferencia(Double r)
        {
            return 2*3.14*r;
        }
        static void Main(string[] args)
        {
            Double raio = 0;
            Double area = 0;
            Console.WriteLine("Calcula o diâmetro, a área e a circunferência de um circulo");
            Console.Write("Informe o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());
            area = calculaArea(raio);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Diâmentro: " + calculaDiametro(raio));
            Console.WriteLine("Circunferência: " + calculaCircunferencia(raio));
            Console.ReadKey();

        }
    }
}
