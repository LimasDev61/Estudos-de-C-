using System;
using System.Globalization;

namespace Exercise_4_OOP_EmployeSalary;

class Salary
{
    /*
     *
     * Fazer um programa para ler os dados de um funcionário (nome,
     * salário bruto e imposto). Em seguida, mostrar os dados do
     * funcionário (nome e salário líquido). Em seguida, aumentar o salário
     * do funcionário com base em uma porcentagem dada (somente o
     * salário bruto é afetado pela porcentagem) e mostrar novamente os
     * dados do funcionário.
     *
     */
    static void Main(string[] args)
    {
        SalaryClass salary = new SalaryClass();

        Console.WriteLine("Calcule o salário: ");
        Console.Write("Nome: ");
        salary.Name = Console.ReadLine();
        Console.Write("Salário Bruto: ");
        bool gross = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out salary.GrossSalary);
        Console.Write("Imposto: ");
        bool tax = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out salary.Tax);

        Console.WriteLine("Funcionário: " + salary);

        Console.Write("Digite a porcentagem para aumentar o salário: ");
        bool percent = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out double percents);
        salary.IncreaseSalary(percents);

        Console.WriteLine("Dados Atualizados: " + salary);
    }
}