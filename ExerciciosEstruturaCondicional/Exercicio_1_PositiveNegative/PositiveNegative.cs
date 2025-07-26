using System;

namespace Exercicio_1_PositiveNegative
{
    class PositiveNegative
    {
        /*
         *
         * Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
         * 
         */
        static void Main(string[] args)
        {
            
            bool sucesso = Int32.TryParse(Console.ReadLine(), out int numero);

            if (numero >= 0)
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}

