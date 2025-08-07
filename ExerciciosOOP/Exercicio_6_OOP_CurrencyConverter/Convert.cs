using System;
using System.Globalization;

namespace Exercicio_6_OOP_CurrencyConverter;

class Convert
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a cotação do Dolar: ");
        bool calc0 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double dolar);
        Console.Write("Quantos dólares você vai comprar: ");
        bool calc1 = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double real);
        double convert = CurrencyConvert.CurrencyConvertFunction(dolar, real);

        Console.WriteLine("Valor a ser pago em reais: R$ " + convert.ToString("F2", CultureInfo.InvariantCulture));
    }
}