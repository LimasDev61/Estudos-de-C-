using System;
using System.Globalization;

namespace Resolucao_MembrosEstaticos2_Oop;

class Circumference
{
    static void Main(string[] args)
    {
        Console.Write("Entre com o valor do raio: ");
        bool number = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out double raio);

        double circumference = Calculadora.CalculateRadius(raio);
        double volume = Calculadora.Volume(raio);

        Console.WriteLine("Circunferência: " + circumference.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI: " + Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture));
    }
}