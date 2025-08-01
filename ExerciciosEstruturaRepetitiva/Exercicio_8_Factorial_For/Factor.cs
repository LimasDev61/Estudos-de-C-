using System;

namespace Exercicio_8_Factorial_For;

class Factor
{
    /*
     *
     * Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
     * Lembrando que, por definição, fatorial de 0 é 1.
     *
     */
    static void Main(string[] args)
    {
        int factor = 1;

        bool confirm = int.TryParse(Console.ReadLine(), out int quantidade);

        for (int i = 0; i < quantidade; i++)
        {
            factor *= i + 1;
        }

        Console.WriteLine(factor);
    }
}