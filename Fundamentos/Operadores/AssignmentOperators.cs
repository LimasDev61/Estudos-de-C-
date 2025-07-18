using System;

namespace Operadores
{
    class AssignmentOperators
    {
        public static void Main(string[] args)
        {
            // Atribuição comum;
            int a = 10;
            Console.WriteLine("Apenas atribuição comum da variável iniciada: " + a);
            
            // Operadores de Atribuição Cumulativa
            
            int adicao = 10;
            int subtracao = 10;
            int multiplicacao = 10;
            int divisao = 10;
            int mod = 10;

            adicao += 10;
            subtracao -= 10;
            multiplicacao *= 10;
            divisao /= 2;
            mod %= 3;
            
            Console.WriteLine($"\nAdição: {adicao}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {divisao}");
            Console.WriteLine($"Mod - Resto da divisão: {mod}");
            
            // Operador de atribuição de adição também funciona com strings:

            string nome = "Hello ";
            nome += "World!";
            
            Console.WriteLine("\nTeste do operador de atribuição de adição, para strings: " + nome);

            Console.WriteLine("----------------------------------------------------------------------");
            // Operadores aritméticos de atribuição

            Console.WriteLine("Use primeiro, incremente depois:");
            int x = 10;
            int y = x++;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nIncremente primeiro, use depois:");
            int x1 = 10;
            int y1 = ++x1;
            Console.WriteLine(x1);
            Console.WriteLine(y1);
        }
    }
}