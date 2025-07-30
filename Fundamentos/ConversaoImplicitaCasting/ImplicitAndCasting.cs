using System;

namespace ConversaoImplicitaCasting
{
    class ImplicitAndCasting
    {
        static void Main(string[] args)
        {
            // Conversão implicita menor < maior
            Console.WriteLine("Conversão Implicita:");
            float h1 = 35.2f;

            double h2 = h1;

            Console.WriteLine(h2.ToString("F2"));

            // Erro da implicita quando utilizamos de maior > menor

            double errorConversion = 35.20;

            // erro nessa linha > float errorConversion1 = errorConversion; 

            // Casting maior < menor;

            Console.WriteLine();
            Console.WriteLine("Casting:");
            double h3 = 34.5;

            int h4 = (int)h3; // Parte truncada, perde a parte decimal

            Console.WriteLine(h4);
            
            // Casting para operação:
            Console.WriteLine();
            Console.WriteLine("Casting por operadores:");
            int a = 5;
            int b = 2;

            double resultado = (double) a / b;
            
            Console.WriteLine(resultado);
        }
    }
}