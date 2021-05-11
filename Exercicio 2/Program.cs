using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double alcool = 4.90;
            double gasolina = 5.30;
            double quantidade = 0;
            double desconto = 0;
            double valor = 0;
            string tipo_de_combustivel = "";
            bool repetir = false;
            
            do
            {
            Console.WriteLine("Qual o combustivel A - Álcool, G - Gasolina");
            tipo_de_combustivel = Console.ReadLine().ToLower();

            switch (tipo_de_combustivel)
            {
                case "a":
                    Console.WriteLine("Qual a quantidade de combústivel colocada?");
                    quantidade = double.Parse(Console.ReadLine());
                    if (quantidade <= 20)
                    {
                        desconto = alcool * 0.97;
                        valor = desconto * quantidade;
                        Console.Write("Voce devera pagar: " + valor.ToString("N2"));
                        repetir = true;
                    }
                    else
                    {
                        desconto = alcool * 0.95;
                        valor = desconto * quantidade;
                        Console.Write("Voce devera pagar: " + valor.ToString("N2"));
                        repetir = true;
                    }
                    break;
                case "g":
                    Console.WriteLine("Qual a quantidade de combústivel colocada?");
                    quantidade = double.Parse(Console.ReadLine());
                    if (quantidade <= 20)
                    {
                        desconto = gasolina * 0.96;
                        valor = desconto * quantidade;
                        Console.Write("Voce devera pagar: " + valor.ToString("N2"));
                        repetir = true;
                    }
                    else
                    {
                        desconto = gasolina * 0.94;
                        valor = desconto * quantidade;
                        Console.Write("Voce devera pagar: " + valor.ToString("N2"));
                        repetir = true;
                    }
                    break;
                default:
                Console.WriteLine("Você digitou um valor invalido favor comece novamente");
                    break;
            }
                
            } while (repetir == false);

        }
    }
}
