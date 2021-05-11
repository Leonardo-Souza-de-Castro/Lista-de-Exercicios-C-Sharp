using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = null;
            int quantidade_numeros = 15;
            numeros = new int[quantidade_numeros];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numeros);
            Console.WriteLine("Os valores digitados invertidos são: ");
            foreach (var i in numeros)
            {
                Console.Write(i + " ,");
            }

        }
    }
}
