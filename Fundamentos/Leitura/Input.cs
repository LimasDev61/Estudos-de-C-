using System;
using System.Globalization;

namespace Escrita
{
    class Input
    {
        static void Main(string[] args)
        {
            // Ler Texto até a quebra de linha, armazenando em uma variável.
            Console.Write("Escreva a frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("\nResultado: " + frase);

            // Ler três palavras cada uma em uma variável.
            Console.WriteLine("\nEscreva três palavras em cada linha: ");
            Console.Write("Palavra 1: ");
            string r = Console.ReadLine();
            Console.Write("Palavra 2: ");
            string g = Console.ReadLine();
            Console.Write("Palavra 3: ");
            string b = Console.ReadLine();

            Console.WriteLine("\nResultado R: " + r);
            Console.WriteLine("Resultado G: " + g);
            Console.WriteLine("Resultado B: " + b);

            Console.WriteLine("\nEscreva três palavras na mesma linha: ");
            Console.Write("Palavra 1: ");
            string r1 = Console.ReadLine();
            Console.Write("Palavra 2: ");
            string g1 = Console.ReadLine();
            Console.Write("Palavra 3: ");
            string b1 = Console.ReadLine();

            Console.WriteLine($"{r1} {g1} {b1}");

            Console.WriteLine("\nEscreva três palavras na mesma linha com o metodo split: ");
            Console.Write("Escreva a frase: ");
            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine();
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine($"Resultado: {p1} {p2} {p3}");

            Console.WriteLine("\nTeste de entra de dados com parse:");
            Console.Write("Escreva a idade: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("\nEscreva o sexo - F ou M: ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("\nEscreva a nota: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.WriteLine("\nFicha Cadastral:");
            Console.Write("Escreva o seu nome, sexo, idade e altura: ");
            string[] vet1 = Console.ReadLine().Split(' ');
            string nome = vet1[0];
            string sexo = vet1[1];
            string idade = vet1[2];
            double altura = double.Parse(vet1[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {nome} Sexo: {sexo} idade: {idade} altura: {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}