using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
                //- Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
                // preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
                // desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
                // - Se quantidade &lt;= 5 o desconto será de 2%
                // - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
                // - Se quantidade &gt; 10 o desconto será de 5%
            
            string produto;
            int quantidade;
            double  precounitario, total, totalAPagar;

            Console.Write("Digite o nome do produto: ");
            produto = Console.ReadLine();
            
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o Preço Unitário: ");
            precounitario = double.Parse(Console.ReadLine());
            
            total = quantidade * precounitario;
            Console.WriteLine($"Preço total :{total}");
            
            if (quantidade <=5){
                totalAPagar = total - (total*0.02);
            }else if (quantidade > 5 && quantidade <=10){
                totalAPagar = total - (total*0.03); 
            }else{
                totalAPagar = total - (total*0.05);
            }

            Console.WriteLine($"O preço a Pagar é R${totalAPagar}");
        }
    }
}
