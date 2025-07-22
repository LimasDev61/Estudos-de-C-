using System;
using System.Globalization;

namespace ExerciciosFundamentos
{
    class OutputLesson
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            string globalization = medida.ToString("F3", CultureInfo.InvariantCulture);

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, preço: $ {preco1:F2}");
            Console.WriteLine($"{produto2}, preço: $ {preco2:F2}\n");

            Console.WriteLine($"{idade} anos de idade, código {codigo} e gênero {genero}\n");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {globalization}");
        }
    }
}