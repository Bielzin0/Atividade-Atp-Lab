using System;

namespace Roteiro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Exercício 1) 

            int x, x1, res;
            Console.WriteLine("Insira dois números");
            x = int.Parse(Console.ReadLine());
            x1 = int.Parse(Console.ReadLine());
            res = (x - x1);
            Console.WriteLine("A subtração é igual a:{0}", res);
        }
    }
}