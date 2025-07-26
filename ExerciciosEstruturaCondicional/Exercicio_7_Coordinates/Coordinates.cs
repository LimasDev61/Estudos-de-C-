using System;
using System.Globalization;

namespace Exercicio_6_Interval
{
    class Interval
    {
        static void Main(string[] args)
        {
            string[] coordenadas = Console.ReadLine().Split(' ');
            double.TryParse(coordenadas[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double eixoX);
            double.TryParse(coordenadas[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double eixoY);

            if (eixoY == 0.0 && eixoX == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (eixoY == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (eixoX == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (eixoX > 0.0 && eixoY > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (eixoX < 0.0 && eixoY < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (eixoX < 0.0 && eixoY > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            {
            }
        }
    }
}