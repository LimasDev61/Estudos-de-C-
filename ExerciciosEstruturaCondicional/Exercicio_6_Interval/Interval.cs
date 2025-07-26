using System;
using System.Globalization;

namespace Exercicio_6_Interval
{
    class Interval
    {
        /*
         * 
         * Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
         * seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o
         * valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
         * 
         */
        static void Main(string[] args)
        {
            bool entrada = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
                out double numero);
            
            if (numero >= 0 && numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero > 25.0 && numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero > 50.0 && numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (numero > 75.0 && numero <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}