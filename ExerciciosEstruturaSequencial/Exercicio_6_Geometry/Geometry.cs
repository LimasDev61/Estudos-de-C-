using System;
using System.Globalization;

namespace Exercicio_6_Geometry
{
    class Geometry
    {
        /*
         *
         * Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida,
         * calcule e mostre:
         *
         * a) a área do triângulo retângulo que tem A por base e C por altura.
         * b) a área do círculo de raio C. (pi = 3.14159)
         * c) a área do trapézio que tem A e B por bases e C por altura.
         * d) a área do quadrado que tem lado B.
         * e) a área do retângulo que tem lados A e B.
         *  
         */
        
        private const double PI = 3.14159;

        static void Main(string[] args)
        {
            string[] valueGeometry = Console.ReadLine().Split(' ');

            double valueA = double.Parse(valueGeometry[0], CultureInfo.InvariantCulture);
            double valueB = double.Parse(valueGeometry[1], CultureInfo.InvariantCulture);
            double valueC = double.Parse(valueGeometry[2], CultureInfo.InvariantCulture);

            double triangulo = valueA * valueC / 2.0;
            double raio = Math.Pow(valueC, 2) * PI;
            double trapezio = (valueA + valueB) * valueC / 2.0;
            double quadrado = Math.Pow(valueB, 2);
            double retangulo = valueA * valueB;

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {raio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
