using System;

namespace Roteiro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Exercício 5) 

            float sm, vl, qsm;
            Console.WriteLine("Insira o valor do salário mínimo e o valor do salário do funcionário");
            sm = float.Parse(Console.ReadLine());
            vl = float.Parse(Console.ReadLine());
            qsm = vl / sm;
            Console.WriteLine("Esse funcionário ganha um total de:{0} salários mínimos", qsm);
        }
    }
}