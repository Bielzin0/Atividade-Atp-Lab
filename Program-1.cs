using System;

namespace Roteiro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Exercício 2) 

            float nota1, nota2, mp;
            Console.WriteLine("Insira o valor das notas");
            nota1 = float.Parse(Console.ReadLine());
            nota2 = float.Parse(Console.ReadLine());
            mp = (nota1 * 2 + nota2 * 3) / 5;
            Console.WriteLine("A média ponderada é de:{0}", mp);
        }
    }
}