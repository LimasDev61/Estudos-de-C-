using System;

namespace OperadoresComparativos
{
    class Comparatives
    {
        static void Main(string[] args)
        {
            
            // Comparativo maior
            int a = 10;
            bool condicao1 = a > 10;
            Console.WriteLine("Condição 1, maior A > 10: " + condicao1);
            
            // Comparativo menor
            int b = 10;
            bool condicao2 = b < 11;
            Console.WriteLine("Condição 2, menor B < 11: " + condicao2);
            
            // Comparativo maior ou igual
            int c = 10;
            bool condicao3 = c >= 10;
            Console.WriteLine("Condição 3, maior ou igual C >= 10: " + condicao3);
            
            // Comparativo menor ou igual
            int d = 11;
            bool condicao4 = d <= 10;
            Console.WriteLine("Condição 4, maior ou igual D <= 11: " + condicao4);
            
            // Comparativo igual
            int e = 10;
            int f = 9;
            bool condicao5 = e == f;
            Console.WriteLine("Condição 5, E igual a F: " + condicao5);
            
            // Comparativo diferente
            int g = 10;
            bool condicao6 = g != 11;
            Console.WriteLine("Condição 6, G é diferente de 11: " + condicao6);
        }
    }
}

