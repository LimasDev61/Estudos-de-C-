using System;
using System.Globalization;

namespace Exercicio_4_SalaryIncrease
{
    class SalaryIncrease
    {
        
        /*
         *
         * Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que
         * recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do
         * funcionário, com duas casas decimais.
         * 
         */
        static void Main(string[] args)
        {
            int funcionarioNumero = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioTotal = horasTrabalhadas * valorHora;

            Console.WriteLine($"NUMBER = {funcionarioNumero}");
            Console.WriteLine($"SALARY = U$ {salarioTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}