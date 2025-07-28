using System;

namespace Funcoes
{
    class Functions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            bool n1 = int.TryParse(Console.ReadLine(), out int numero1);
            bool n2 = int.TryParse(Console.ReadLine(), out int numero2);
            bool n3 = int.TryParse(Console.ReadLine(), out int numero3);

            Console.WriteLine("O maior numero é: " + Maior(numero1, numero2, numero3));
            static int Maior(int numero1, int numero2, int numero3)
            {
                int m = numero1;
                if (numero2 > m)
                {
                    m = numero2;
                }

                if (numero3 > m)
                {
                    m = numero3;
                }

                return m;
            }
        }
    }
}