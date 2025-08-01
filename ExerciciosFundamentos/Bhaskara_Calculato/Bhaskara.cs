using System;
using System.Globalization;

namespace Bhaskara_Calculatos;

class Bhaskara
{
    static void Main(string[] args)
    {
        string[] coeficientes = Console.ReadLine().Split(' ');
        bool entrada1 = double.TryParse(coeficientes[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double a);
        bool entrada2 = double.TryParse(coeficientes[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double b);
        bool entrada3 = double.TryParse(coeficientes[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double c);

        double delta = Delta(a, b, c);

        if (delta < 0.0 || a == 0.0)
        {
            Console.WriteLine("Operação Inválida");
            return;
        }

        CalcularRaizes(a, b, delta);
        static double Delta(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4.0 * a * c;
        }

        static void CalcularRaizes(double a, double b, double delta)
        {
            double raiz1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double raiz2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"X1 = {raiz1.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"X2 = {raiz2.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}