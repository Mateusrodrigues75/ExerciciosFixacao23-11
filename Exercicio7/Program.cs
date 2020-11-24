using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
           float[] valores = new float[15];
            for (var i = 0; i < 15; i++) 
            {

            Console.WriteLine("Digite o número: ");
            valores[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Lista dos números na ordem inversa: ");

            Array.Reverse(valores);
            
            foreach(float lista in valores){
                Console.WriteLine(lista);
                
            }
            
        }
    }
}
