using System;

namespace Exercicio_3_Multiples
{
    class Multiples
    {
        static void Main(string[] args)
        {
            bool sucesso1 = Int32.TryParse(Console.ReadLine(), out int numero1);
            bool sucesso2 = Int32.TryParse(Console.ReadLine(), out int numero2);

            if (numero1 > 0 && numero2 > 0)
            {
                if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
                {
                    Console.WriteLine("Sao Multiplos");
                }
                else
                {
                    Console.WriteLine("Nao sao Multiplos");
                }
            }
        }
    }
}