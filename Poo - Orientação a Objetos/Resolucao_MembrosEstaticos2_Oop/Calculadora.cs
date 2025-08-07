namespace Resolucao_MembrosEstaticos2_Oop;

public class Calculadora
{
    public static double PI = 3.141592;
    
    public static double CalculateRadius(double radius)
    {
        return 2.0 * PI * radius;
    }

    public static double Volume(double volume)
    {
        return 4.0 / 3.0 * PI * Math.Pow(volume, 3.0);
    }
}