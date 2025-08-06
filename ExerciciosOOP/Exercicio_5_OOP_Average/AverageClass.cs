using System.Globalization;

namespace Exercicio_5_OOP_Average;

public class AverageClass
{
    public string Name;
    public double A;
    public double B;
    public double C;

    public double AddNote()
    {
        return A + B + C;
    }

    public bool Approved()
    {
        if (AddNote() >= 60.0)
        {
            return true;
        }

        return false;
    }

    public double RemainingNote()
    {
        if (Approved())
        {
            return 0.0;
        }

        return 60.0 - AddNote();
    }

    public override string ToString()
    {
        return "Nota Final = "
               + $"{AddNote().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}