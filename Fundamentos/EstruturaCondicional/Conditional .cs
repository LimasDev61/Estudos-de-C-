using System;
using System.Globalization;

namespace EstruturaCondicional
{
    class Conditional
    {
        static void Main(string[] args)
        {
            bool numero = int.TryParse(Console.ReadLine(), out int numeroTry);

            if (numeroTry >= 1 && numeroTry < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (numeroTry >= 12 && numeroTry < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (numeroTry >= 18 && numeroTry <= 24)
            {
                Console.WriteLine("Boa noite!");
            }

            if (!(numeroTry >= 1 && numeroTry <= 24))
            {
                Console.WriteLine("Hora inválida!");
            }
            else if (numeroTry < 6 || numeroTry >= 23)
            {
                Console.WriteLine("Vai dormir, tá tarde!");
            }

            if (numeroTry % 2 == 0) 
            {
                Console.WriteLine("É par!");
            }
            else
            {
                Console.WriteLine("É impa!");
            }
        }
    }
}