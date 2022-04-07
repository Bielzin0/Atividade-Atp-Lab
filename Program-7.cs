using System;

namespace Roteiro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Exercício 8) 

            int a1, a2, a3;
            Console.WriteLine("Insira o valor dos ângulos do triângulo");
            a1 = int.Parse(Console.ReadLine());
            a2 = int.Parse(Console.ReadLine());
            a3 = 180 - a1 - a2;
            Console.WriteLine("A medida do terceiro ângulo é de:{0}", a3);
        }
    }
}   