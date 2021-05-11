using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade_numeros = 10;
            int[] numeros = new int[quantidade_numeros];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);
                Console.WriteLine("O maior valor é: " + numeros[0]);
                Console.WriteLine("O menor valor é: " + numeros[9]);
                
        }
    }
}
