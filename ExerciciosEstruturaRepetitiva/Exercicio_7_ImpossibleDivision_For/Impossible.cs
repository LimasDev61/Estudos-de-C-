using System;
using System.Globalization;

namespace Exercicio_7_ImpossibleDivision_For
{
    class Impossible
    {
        /*
         *
         * Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
         * segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel". 
         * 
         */
        static void Main(string[] args)
        {
            bool confirm = int.TryParse(Console.ReadLine(), out int quantidade);

            for (int i = 0; i < quantidade; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                bool denomi1 = double.TryParse(numeros[0], NumberStyles.Any, CultureInfo.InvariantCulture,
                    out double denominador1);
                bool denomi2 = double.TryParse(numeros[1], NumberStyles.Any, CultureInfo.InvariantCulture,
                    out double denominador2);

                if (denominador2 == 0)
                {
                    Console.WriteLine("divisão impossivel");
                }
                else
                {
                    double resultado = denominador1 / denominador2;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}