using System;

namespace Exercicio_9_Dividers_For;

class Dividers
{
    /*
     *
     * Ler um número inteiro N e calcular todos os seus divisores
     * 
     */
    static void Main(string[] args)
    {
        bool confirm = int.TryParse(Console.ReadLine(), out int dividend);

        for (int i = 1; i <= dividend; i++)
        {
            if (dividend % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}