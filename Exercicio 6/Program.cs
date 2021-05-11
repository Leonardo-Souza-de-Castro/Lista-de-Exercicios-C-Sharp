using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = null;
            string nome = null;

            for (var i = 0; i < 11; i++)
            {
                Console.Write("Insira um nome por favor: ");
                nomes[i] = Console.ReadLine();
            }

            Console.Write("Digite mais um nomes para nossa comparação");
            nome = Console.ReadLine();

            foreach (var item in nomes)
            {
                Console.WriteLine(nomes);
            }
        }
    }
}
