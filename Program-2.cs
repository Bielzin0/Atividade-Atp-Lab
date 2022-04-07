using System;

namespace Roteiro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Exercício 3) 

            double p, np;
            Console.WriteLine("Insira o preço do produto");
            p = double.Parse(Console.ReadLine());
            np = p - (p * 0.1);
            Console.WriteLine("O novo preço do produto será de:{0}", np);
        }
    }
}