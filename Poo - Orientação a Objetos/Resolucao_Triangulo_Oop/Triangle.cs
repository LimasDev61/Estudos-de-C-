using System;
using System.Globalization;

namespace Resolucao_Triangulo_Oop;

class Triangles
{
    static void Main(string[] args)
    {
        TriangleClass x = new TriangleClass();
        TriangleClass y = new TriangleClass();

        Console.WriteLine("Entre com as medidas do triângulo X:");
        bool entrada1 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out x.A);
        bool entrada2 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out x.B);
        bool entrada3 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out x.C);

        Console.WriteLine();

        Console.WriteLine("Entre com as medidas do triângulo Y:");
        bool entrada4 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out y.A);
        bool entrada5 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out y.B);
        bool entrada6 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out y.C);

        double p = (x.A + x.B + x.C) / 2.0;
        double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

        p = (y.A + y.B + y.C) / 2.0;
        double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

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