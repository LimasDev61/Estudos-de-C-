using System;
using System.Globalization;

namespace Exercicio_8_Lizarb
{
    class Lizarb
    {
        static void Main(string[] args)
        {
            
            bool valor = double.TryParse(Console.ReadLine(), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out double rombus);

            double imposto = 0.0;
            if (rombus <= 3000.0)
            {
                imposto = (rombus - 2000.0) / 100.0 * 8.0;
            }
            else if (rombus <= 4500.0)
            {
                imposto = (rombus - 3000.0) / 100 * 18 + 1000 / 100 * 8.0;
            }
            else if (rombus > 4500.0)
            {
                imposto = (rombus - 4500.0) / 100 * 28 + 1500 / 100 * 18.0 + 1000 / 100 * 8.0;;
            }

            if (imposto <= 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}