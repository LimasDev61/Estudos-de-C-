using System;
using System.Globalization;

namespace RepetitivaWhile
{
    class While
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            bool argumento = int.TryParse(Console.ReadLine(), out int numero);
            {
                {
                    while (numero > 0.0)
                    {
                        double raiz = RaizQuadrada(numero);
                        Console.WriteLine(
                            $"A raiz quadrada de {numero} é: {raiz.ToString("F3", CultureInfo.InvariantCulture)}");
                        Console.Write("Digite outro numero: ");
                        int.TryParse(Console.ReadLine(), out numero);
                    }
                }
            }

            Console.WriteLine("Número Negativo!");

            static double RaizQuadrada(double numero)
            {
                return Math.Sqrt(numero);
            }
        }
    }
}