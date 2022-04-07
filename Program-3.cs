using System;

namespace Roteiro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Exercício 4) 

            double bmaior, bmenor, alt, area;
            Console.WriteLine("Insira a base maior, base menor e altura do trapézio");
            bmaior = double.Parse(Console.ReadLine());
            bmenor = double.Parse(Console.ReadLine());
            alt = double.Parse(Console.ReadLine());
            area = ((bmaior - bmenor) * alt) / 2;
            Console.WriteLine("A área do trapézio é de:{0}", area);
        }
    }
}