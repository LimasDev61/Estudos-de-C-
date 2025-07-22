using System;
using System.Globalization;

namespace InputLesson
{
    class Input
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com os dados do seu último nome, idade e altura: ");
            string[] dadosDoFinais = Console.ReadLine().Split(' ');

            string nomeFinal = dadosDoFinais[0];
            int idade = int.Parse(dadosDoFinais[1]);
            double alturaFinal = double.Parse(dadosDoFinais[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome Completo: {nomeCompleto}");
            Console.WriteLine($"Quantidade de Quartos: {quartos}");
            Console.WriteLine($"Preço do Produto: {preco.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Sobrenome Final: {nomeFinal}:");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {alturaFinal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}