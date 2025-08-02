using System;
using System.Globalization;

namespace Rosolucao_Sem_Oop;

class Triangles
{
    static void Main(string[] args)
    {
        double xA, xB, xC;
        double yA, yB, yC;
        double areaX = 0.0;
        double areaY = 0.0;
        Console.WriteLine("Entre com as medidas do triângulo X:");
        bool entrada1 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out xA);
        bool entrada2 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out xB);
        bool entrada3 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out xC);

        Console.WriteLine();

        Console.WriteLine("Entre com as medidas do triângulo Y:");
        bool entrada4 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out yA);
        bool entrada5 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out yB);
        bool entrada6 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out yC);

        double p = (xA + xB + xC) / 2.0;
        areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

        p = (yA + yB + yC) / 2.0;
        areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

        Console.WriteLine($"Area de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Area de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

        if (areaX > areaY)
        {
            Console.WriteLine("Maior área: X");
        }
        else if (areaX == areaY)
        {
            Console.WriteLine("As áreas são iguais.");
        }
        else
        {
            Console.WriteLine("Maior área: Y");
        }
    }
}