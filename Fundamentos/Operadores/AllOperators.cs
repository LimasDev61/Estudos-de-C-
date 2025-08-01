﻿using System;
using System.Globalization;

namespace Operadores
{
    class AllOperators
    {
        static void Main(string[] args)
        {
            // Atribuição comum;
            Console.WriteLine("Operadores Aritméticos:");
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8.0;
            double n4Casting = (double) 10 / 8;

            Console.WriteLine("\nResultado sem parentêsis: " + n1);
            Console.WriteLine("Resultado com parentêsis: " + n2);
            Console.WriteLine("Resultado com parentêsis com mod: " + n3);
            Console.WriteLine("Resultado da divisão: " + n4);
            Console.WriteLine("Resultado da divisão com casting: " + n4Casting.ToString("F2", CultureInfo.InvariantCulture));
            
            // Teste com o calculo de Bhaskara
            Console.WriteLine("\nFórmula de Bhaskara:");
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c ;

            double x1Raiz = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2Raiz = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"\nResultado da primeira raiz: {x1Raiz:F1}");
            Console.WriteLine($"Resultado da segunda raiz: {x2Raiz:F1}");
            
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            // Operadores de Atribuição Cumulativa
            Console.WriteLine();
            Console.WriteLine("Operadores de Atribuição Cumulativa:");
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
            Console.WriteLine();
            Console.WriteLine("Operador de Atribuição com String:");
            string nome = "Hello ";
            nome += "World!";

            Console.WriteLine("\nTeste do operador de atribuição de adição, para strings: " + nome);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");

            // Operadores aritméticos de atribuição
            Console.WriteLine();
            Console.WriteLine("Incremento e Decremento:");
            Console.WriteLine("\nUse primeiro, incremente depois:");
            int x = 10;
            int y = x++;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nIncremente primeiro, use depois:");
            int x1 = 10;
            int y1 = ++x1;
            Console.WriteLine(x1);
            Console.WriteLine(y1);

            Console.WriteLine();
            Console.WriteLine("Use primeiro, decremente depois:");
            int d1 = 10;
            int d2 = d1--;
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Console.WriteLine("\nDecremente primeiro, use depois:");
            int d3 = 10;
            int d4 = --d3;
            Console.WriteLine(d3);
            Console.WriteLine(d4);
        }
    }
}