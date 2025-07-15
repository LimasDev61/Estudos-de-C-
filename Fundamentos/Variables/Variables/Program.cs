using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool verificar = false;
            char sexo = 'F';
            char letra = '\u0041'; // unicode
            SByte numero = 100; // o SByte ele é um tipo do .NET, é necessário o using System;
            Byte n1 = 255; // Numero com overflow;
            n1++;
            int n2 = 1000;
            int n3 = 2147483647; // limite máximo do int;
            long n4 = 9223372036854775807L; // limite máximo do long;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "C#";
            
            // Object é a classe generica, todas as outras classes se derivam dela.

            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            
            // Testando o MinValue e o MaxValue
            
            int maxValue = int.MaxValue;
            int minValue = int.MinValue;
            sbyte sbyte1 = sbyte.MaxValue;
            sbyte sbyte2 = sbyte.MinValue;
            decimal decimal1 = decimal.MaxValue;
            
            
            Console.WriteLine(verificar);
            Console.WriteLine(sexo);
            Console.WriteLine(letra);
            Console.WriteLine(numero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
            Console.WriteLine(sbyte1);
            Console.WriteLine(sbyte2);
            Console.WriteLine(decimal1);
        }
    }
}