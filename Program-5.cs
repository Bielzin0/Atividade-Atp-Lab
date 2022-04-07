using System;

namespace Roteiro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Exercício 6) 

            double c1, c2, hipotenusa;
            Console.WriteLine("Insira o valor dos catetos");
            c1 = double.Parse(Console.ReadLine());
            c2 = double.Parse(Console.ReadLine());
            hipotenusa = Math.Sqrt((c1 * c1 + c2 * c2));
            Console.WriteLine("O valor da hipotenusa será de:{0}", hipotenusa);
        }
    }
}