using System;

namespace RepetitivaFor
{
    class For
    {
        static void Main(string[] args)
        {
            int soma = 0; 

            Console.Write("Quantos números inteiros você vai digitar? ");
            bool numeros = int.TryParse(Console.ReadLine(), out int quantidade);

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Valor #{i + 1}: ");
                bool n = int.TryParse(Console.ReadLine(), out int acumulativo);
                soma += acumulativo;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}