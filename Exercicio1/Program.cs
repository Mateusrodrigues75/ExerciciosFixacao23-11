using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual, anoNascimento, idade;
            Console.WriteLine("Validação de Idade para Votação nas Eleições");
            Console.Write("Digite o Ano Atual: ");
            anoAtual = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o Ano do seu nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

            idade = anoAtual - anoNascimento;

            if(idade >= 16){
                Console.WriteLine("Você poderá votar este ano.");
            }else{
                Console.WriteLine("Você não poderá votar este ano.");
                
            }



            
        }
    }
}
