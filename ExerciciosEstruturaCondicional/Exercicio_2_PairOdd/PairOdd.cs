using System;

namespace Exercicio_2_PairOdd
{
    class PairOdd
    {
        /*
         *
         * Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar. 
         * 
         */
        static void Main(string[] args)
        {
            
            bool sucesso = Int32.TryParse(Console.ReadLine(), out int numero);

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}

