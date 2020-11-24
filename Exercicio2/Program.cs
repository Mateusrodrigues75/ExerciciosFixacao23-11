using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoG = 5.30;
            double precoE = 4.90;

            Console.Write("Digite o volume do abastecimento em litros: ");
            double volumeCombustivel = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha e digite o tipo de combustível abaixo: ");
            Console.WriteLine("G - Gasolina");
            Console.WriteLine("A - Álcool");
            string tipoCombustivel = Console.ReadLine();

            switch(tipoCombustivel)
            {
                case "G":
                if(tipoCombustivel == "G" && volumeCombustivel<= 20)
                {
                    Console.WriteLine("Abastecimento com Gasolina !");
                    double valorAbastecimento = (precoG * volumeCombustivel) * 0.96;
                    Console.WriteLine("O valor do abastecimento com desconto é de : R$ "+valorAbastecimento);
                }
                if(tipoCombustivel == "G" && volumeCombustivel> 20)
                {
                    Console.WriteLine("Abastecimento com Gasolina !");
                    double valorAbastecimento = (precoG * volumeCombustivel) * 0.94;
                    Console.WriteLine("O valor do abastecimento com desconto é de : R$ "+valorAbastecimento);
                }
                break;


                case "A": 
                
                if(tipoCombustivel == "A" && volumeCombustivel<= 20)
                {
                    Console.WriteLine("Abastecimento com Etanol !");
                    double valorAbastecimento = (precoE * volumeCombustivel) * 0.97;
                    Console.WriteLine("O valor do abastecimento com desconto é de : R$ "+valorAbastecimento);
                }
                if(tipoCombustivel == "A" && volumeCombustivel> 20)
                {
                    Console.WriteLine("Abastecimento com Etanol !");
                    double valorAbastecimento = (precoE * volumeCombustivel) * 0.95;
                    Console.WriteLine("O valor do abastecimento com desconto é de : R$ "+valorAbastecimento);
                }
                break;
            }
        }
    }
}
