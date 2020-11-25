using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicacao;
            int[] limite = new int [10];
            Console.WriteLine("Tabuada de 1 a 10");
            Console.WriteLine("-----------------");

            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Tabuada do {i}");

                for (var cont = 1; cont <= 10; cont++)
                {
                    multiplicacao = i * cont;
                    Console.WriteLine ($"{i} * {cont} = {multiplicacao}");
                }
                Console.WriteLine("-----------------------------");

            }

        }
    }
}
