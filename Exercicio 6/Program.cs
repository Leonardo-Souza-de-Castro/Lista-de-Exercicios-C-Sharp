using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            string nome = null;
            bool resposta = false;

            for (var i = 0; i < 10; i++)
            {
                Console.Write("Insira um nome por favor: ");
                nomes[i] = Console.ReadLine().ToLower();
            }

            Console.Write("Digite mais um nomes para nossa comparação: ");
            nome = Console.ReadLine().ToLower();

            foreach (var item in nomes)
            {
                if (nome == item)
                {
                    resposta = true;
                }
            }
                if (resposta)
                {
                    Console.WriteLine("Achamos!!");
                } else
                {
                    Console.WriteLine("Não achei esse nome no nosso sistema :(");
                }
        }
    }
}
