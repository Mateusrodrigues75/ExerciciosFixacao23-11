using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] valores = new float [10];
            float menor = 0, maior = 0;
            Console.WriteLine("------------Digite 10 valores---------------");
            for (var i = 0; i < valores.Length; i++){
                Console.Write($"Digite o {i+1}° valor: ");
                valores[i] = float.Parse(Console.ReadLine());

                menor=valores[0];
                if(valores[i] < menor){
                    
                    menor = valores[i];
                }
                else if (valores[i] > maior){
                    maior = valores[i];
                }
            }
            Console.WriteLine("O menor número é:" + menor);
            Console.WriteLine("O maior número é:" + maior);
        }
    }
}
