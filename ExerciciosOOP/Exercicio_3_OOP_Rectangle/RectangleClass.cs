using System.Globalization;

namespace Exercise_3_OOP_Rectangle;

public class RectangleClass
{
    public double A;
    public double B;

    public double CalculateArea()
    {
        return A * B;
    }

    public double CalculatePerimeter()
    {
        return A * 2.0 + B * 2.0;
    }

    public double CalculateDiagonal()
    {
        return Math.Sqrt(A * A + B * B);
    }

    public override string ToString()
    {
        return $"AREA: {CalculateArea().ToString("F2", CultureInfo.InvariantCulture)}"
               + Environment.NewLine
               + $"PERIMETER: {CalculatePerimeter().ToString("F2", CultureInfo.InvariantCulture)}"
               + Environment.NewLine
               + $"DIAGONAL: {CalculateDiagonal().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}