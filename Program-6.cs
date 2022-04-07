using System;

namespace Roteiro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Exercício 7) 

            //* Exercício a) *//

            double raio, comp, area, vol;
            Console.WriteLine("Insira o valor do raio da esfera");
            raio = double.Parse(Console.ReadLine());
            comp = 2 * Math.PI * raio;
            area = Math.PI * Math.Pow(raio, 2);
            vol = (4 * Math.PI * Math.Pow(raio, 3)) / 3;
            
            //* Exercício a) 
            Console.WriteLine("O valor do comprimento é de:{0}", comp);

            //* Exercício b) 
            Console.WriteLine("A área da esfera é :{0}", area);

            //* Exercício c) 
            Console.WriteLine("O volume da esfera é:{0}", vol);
        }
    }
}