namespace Exercicio_6_OOP_CurrencyConverter;

public class CurrencyConvert
{
    public static double IoF = 6.0;

    public static double CurrencyConvertFunction(double real, double cotacao)
    {
        return (IoF / 100.0 + 1.0) * (real * cotacao);
    }
}