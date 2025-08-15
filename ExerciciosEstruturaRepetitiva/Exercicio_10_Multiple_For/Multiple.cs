using System;

namespace Exercicio_10_Multiple_For;

class Multiple
{
    /*
     *
     * Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
     * começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
     * exemplo.
     * 
     */
    static void Main(string[] args)
    {
        bool confirm = int.TryParse(Console.ReadLine(), out int multiple);

        for (int i = 1; i <= multiple; i++)
        {
            if (multiple >= 1)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;

                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
    }
}