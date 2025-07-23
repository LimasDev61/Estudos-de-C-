using System;
using System.Globalization;

namespace Exercicio_2_Ray
{
    class Ray
    {
        /*
         *
         * Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da
         * área deste círculo com quatro casas decimais.
         *
         * Fórmula da área: area = π . raio2
         * Considere o valor de π = 3.14159
         *
         */
        const double PI = 3.14159;

        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = Math.Pow(raio, 2) * PI;
            Console.WriteLine($"A={resultado.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}