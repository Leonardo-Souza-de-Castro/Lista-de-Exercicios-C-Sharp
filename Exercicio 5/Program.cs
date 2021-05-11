using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros = 0;
            int resultado = 0;
            bool tabuada = false;

            Console.WriteLine("Digite qual numero você gostaria que mostrassemos a tabuada");
            numeros = int.Parse(Console.ReadLine());
            do
            {
            
            for (var i = 0; i < 11; i++)
            {
                resultado = numeros * i;
                Console.WriteLine("A tabuada é " + resultado);                
            }

            Console.WriteLine("Gostaria de mostrar outra tabuada?");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
            Console.WriteLine("Digite o próximo valor");
            numeros = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Obrigado até a próxima!!");
                tabuada = true;
            }
                
            } while (tabuada == false);
        }
    }
}
