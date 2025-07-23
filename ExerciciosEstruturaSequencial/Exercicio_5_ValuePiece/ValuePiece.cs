using System;
using System.Globalization;

namespace Exercicio_5_ValuePiece
{
    class ValuePiece
        /*
         *
         * Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1,
         * o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor
         * a ser pago.
         *
         */
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');

            int codigo1 = int.Parse(peca1[0]);
            int quantidade1 = int.Parse(peca1[1]);
            double valor1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            int codigo2 = int.Parse(peca2[0]);
            int quantidade2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double calculoPeca1 = quantidade1 * valor1;
            double calculoPeca2 = quantidade2 * valor2;

            double total = calculoPeca1 + calculoPeca2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}