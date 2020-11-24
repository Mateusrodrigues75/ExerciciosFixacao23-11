using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [10];
            string busca;

            
            for (var i = 0; i < nomes.Length; i++){
                Console.WriteLine($"Digite o {i+1}° nome: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Digite um nome para fazer a busca no Array: ");
            busca = Console.ReadLine();
            for (var cont = 0; cont < nomes.Length; cont++){
                if (busca == nomes[cont]){
                    Console.WriteLine("ACHEI");
                    Console.WriteLine($"Nome encontrado: {busca}");
                }else{
                    Console.WriteLine("NÃO ACHEI");
                }
            }
        }
    }
}
