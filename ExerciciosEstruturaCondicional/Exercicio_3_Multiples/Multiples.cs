using System;

namespace Exercicio_3_Multiples
{
    class Multiples
    {
        /*
         *
         * Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou
         * "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem
         * poder ser digitados em ordem crescente ou decrescente. 
         * 
         */
        static void Main(string[] args)
        {
            bool sucesso1 = Int32.TryParse(Console.ReadLine(), out int numero1);
            bool sucesso2 = Int32.TryParse(Console.ReadLine(), out int numero2);

            if (numero1 > 0 && numero2 > 0)
            {
                if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
                {
                    Console.WriteLine("Sao Multiplos");
                }
                else
                {
                    Console.WriteLine("Nao sao Multiplos");
                }
            }
        }
    }
}