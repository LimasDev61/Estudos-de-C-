using System;
using System.Globalization;

namespace Exercicio_6_Weighted_For
{
    class Weighted
    {
        /*
         *
         * Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
         * de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
         * conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
         * peso 5.
         *
         */
        static void Main(string[] args)
        {
            bool confirm = int.TryParse(Console.ReadLine(), out int quantidade);

            for (int i = 0; i < quantidade; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                bool a = float.TryParse(valores[0], NumberStyles.Any, CultureInfo.InvariantCulture, out float numero1);
                bool b = float.TryParse(valores[1], NumberStyles.Any, CultureInfo.InvariantCulture, out float numero2);
                bool c = float.TryParse(valores[2], NumberStyles.Any, CultureInfo.InvariantCulture, out float numero3);

                float coeficiente = (numero1 * 2.0f + numero2 * 3.0f + numero3 * 5.0f) / 10.0f;

                Console.WriteLine(coeficiente.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}