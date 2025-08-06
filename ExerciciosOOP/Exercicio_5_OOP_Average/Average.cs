using System;
using System.Globalization;
using Exercicio_5_OOP_Average;

namespace Exercise_5_OOP_Average;

class Average
{
    /*
     *
     * Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
     * (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
     * ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
     * para o aluno obter o mínimo para ser aprovado (que é 60 pontos).
     *
     */
    static void Main(string[] args)
    {
        AverageClass student = new AverageClass();

        Console.Write("Digite o nome do aluno: ");
        student.Name = Console.ReadLine();

        Console.WriteLine("Digite as três notas do aluno: ");
        bool student1 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out student.A);
        bool student2 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out student.B);
        bool student3 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out student.C);

        Console.WriteLine(student);

        if (student.Approved())
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
            Console.WriteLine(
                $"Faltaram: {student.RemainingNote().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
        }
    }
}