using System;
using System.Globalization;

namespace Exercicio_2_OOP_AverageSalary;

class Salary
{
    static void Main(string[] args)
    {
        SalaryClass worker1 = new SalaryClass();
        SalaryClass worker2 = new SalaryClass();

        Console.WriteLine("Dados do primeiro funcionário:");
        Console.Write("Nome: ");
        worker1.Name = Console.ReadLine();
        Console.Write("Salary: ");
        bool entrada1 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out worker1.Salary);

        Console.WriteLine("Dados do segundo funcionário:");
        Console.Write("Nome: ");
        worker2.Name = Console.ReadLine();
        Console.Write("Salary: ");
        bool entrada2 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out worker2.Salary);

        double media = AverageSalary(worker1.Salary, worker2.Salary);

        Console.WriteLine($"Salário médio: $ {media.ToString("F2", CultureInfo.InvariantCulture)}");

        static double AverageSalary(double salary1, double salary2)
        {
            return (salary1 + salary2) / 2.0;
        }
    }
}