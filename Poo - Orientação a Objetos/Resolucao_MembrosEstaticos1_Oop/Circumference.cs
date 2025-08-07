using System;
using System.Globalization;

namespace Resolucao_MembrosEstaticos1_Oop;

class Circumference
{
    const double PI = 3.141592;
    
    static void Main(string[] args)
    {
        Console.Write("Entre com o valor do raio: ");
        bool number = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double raio);

        double circumference = CalculateRadius(raio);
        double volume = Volume(raio);

        Console.WriteLine("Circunferência: " + circumference.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " +  volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI: " + PI.ToString("F2", CultureInfo.InvariantCulture));
    }

    static double CalculateRadius(double radius)
    {
        return 2.0 * PI * radius;
    }

    static double Volume(double volume)
    {
        return 4.0 / 3.0 * PI * Math.Pow(volume, 3.0);
    }
}
