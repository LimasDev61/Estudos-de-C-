namespace Types_Ref_And_Value;

class Estruct
{
    static void Main(string[] args)
    {
        Point p;
        p.X = 10;
        p.Y = 20;
        Console.WriteLine(p);
        p = new Point();
        Console.WriteLine(p);
    }
}