using System.Globalization;

namespace Exercise_4_OOP_EmployeSalary;

public class SalaryClass
{
    public string Name;
    public double GrossSalary;
    public double Tax;

    public double LiquidSalary()
    {
        return GrossSalary - Tax;
    }

    public void IncreaseSalary(double percentage)
    {
        GrossSalary += GrossSalary / 100.0 * percentage;
    }

    public override string ToString()
    {
        return Name
               + ", $ "
               + LiquidSalary().ToString("F2", CultureInfo.InvariantCulture);
    }
}