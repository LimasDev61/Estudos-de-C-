using System;

namespace Exercicio_4_Odd_For
{
    class Odd
    {
        /*
         *
         * Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
         * X, se for o caso.
         *
         */
        static void Main(string[] args)
        {
            bool numero = int.TryParse(Console.ReadLine(), out int total);

            for (int i = 1; i <= total; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}