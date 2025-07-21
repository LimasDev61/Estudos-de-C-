using System;
using System.Globalization;

namespace Escrita
{
    class Output
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 18;
            double saldo = 10.35784;
            string nome = "Maria";

            // Saídas:
            Console.WriteLine("WireLine, Quebra Linha - Pula uma Linha"); // Pula uma linha - Quebra de Linha;
            Console.Write("Write, não, eu não quebro linha"); // Não quebra linhas, é escrito tudo na mesma linha;
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine("Ponto como separação de números flutuantes: " +
                              saldo.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine();
            // Saída em Placeholder
            Console.WriteLine("Placeholder(Espaços Reservados): Nome: {0}, idade: {1}, Saldo: {2:F2}", nome, idade,
                saldo.ToString("F2", CultureInfo.InvariantCulture));
            // Saída em Interpolação
            Console.WriteLine(
                $"Interpolação: Nome: {nome}, idade: {idade}, Saldo: {saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            // Saída em concatenação
            Console.WriteLine("Concatenação: " + "Nome " + nome + ", idade " + idade + ", Saldo: " +
                              saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}