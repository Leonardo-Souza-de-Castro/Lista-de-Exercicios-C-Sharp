using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            double quantidade = 0;
            double preco = 0;
            double total = 0;
            double total_pagar = 0;

            Console.WriteLine("Qual o produto?");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos(as) " + nome + " são?");
            quantidade = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço do produto?");
            preco = double.Parse(Console.ReadLine());

            if (quantidade <= 5)
            {
                total = quantidade * preco;
                total_pagar = total * 0.98;
                Console.WriteLine("O preço total é de: " + total);
                Console.WriteLine("Porém com um desconto de 2% fica um total de: " + total_pagar);
            }
            else if ((quantidade > 5) && (quantidade <= 10))
            {
                total = quantidade * preco;
                total_pagar = total * 0.97;
                Console.WriteLine("O preço total é de: " + total);
                Console.WriteLine("Porém com um desconto de 3% fica um total de: " + total_pagar);
            }
            else if (quantidade > 10){
                total = quantidade * preco;
                total_pagar = total * 0.95;
                Console.WriteLine("O preço total é de: " + total);
                Console.WriteLine("Porém com um desconto de 5% fica um total de: " + total_pagar);
            }
        }
    }
}
