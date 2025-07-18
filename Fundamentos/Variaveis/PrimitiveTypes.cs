using System;

namespace Variaveis
{
    class PrimitiveTypes
    {
        static void Main(string[] args)
        {
            // Tipos Primitivos

            // int
            Console.WriteLine("Int:");
            int x = 10;
            int y = Int32.MaxValue; // 2147483647
            int a = Int32.MinValue; // -2147483648
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(a);

            // SByte
            Console.WriteLine();
            Console.WriteLine("SByte:");
            SByte x1 = 10;
            SByte y1 = SByte.MaxValue; // 127
            SByte a1 = SByte.MinValue; // -128
            Console.WriteLine(x1);
            Console.WriteLine(y1);
            Console.WriteLine(a1);

            // Short
            Console.WriteLine();
            Console.WriteLine("Short:");
            short x2 = 10;
            short y2 = Int16.MaxValue; // 32767
            short a2 = Int16.MinValue; // -32768
            Console.WriteLine(x2);
            Console.WriteLine(y2);
            Console.WriteLine(a2);

            Console.WriteLine();
            Console.WriteLine("Long:");
            long x3 = 10;
            long y3 = Int64.MaxValue; // 9223372036854775807
            long a3 = Int64.MinValue; // -9223372036854775808
            Console.WriteLine(x3);
            Console.WriteLine(y3);
            Console.WriteLine(a3);

            Console.WriteLine();
            Console.WriteLine("Byte:");
            byte x4 = 10;
            byte y4 = byte.MaxValue; // 255
            Console.WriteLine(x4);
            Console.WriteLine(y4);

            Console.WriteLine();
            Console.WriteLine("UShort:");
            ushort x5 = 10;
            ushort y5 = UInt16.MaxValue; // 65535
            Console.WriteLine(x5);
            Console.WriteLine(y5);

            Console.WriteLine();
            Console.WriteLine("UInt:");
            uint x6 = 10;
            uint y6 = UInt32.MaxValue; // 4294967295
            Console.WriteLine(x6);
            Console.WriteLine(y6);

            Console.WriteLine();
            Console.WriteLine("ULong:");
            ulong x7 = 10;
            ulong y7 = UInt64.MaxValue; // 18446744073709551615
            Console.WriteLine(x7);
            Console.WriteLine(y7);

            Console.WriteLine();
            Console.WriteLine("Float:");
            float x8 = 10.1f;
            float y8 = float.MaxValue;
            float a8 = float.MinValue;
            Console.WriteLine(x8);
            Console.WriteLine(y8); // 3,4028235E+38
            Console.WriteLine(a8); // -3,4028235E+38

            Console.WriteLine();
            Console.WriteLine("Double:");
            double x9 = 10.11;
            double y9 = double.MaxValue; // 1,7976931348623157E+308
            double a9 = double.MinValue; // -1,7976931348623157E+308
            Console.WriteLine(x9);
            Console.WriteLine(y9);
            Console.WriteLine(a9);

            Console.WriteLine();
            Console.WriteLine("Decimal:");
            decimal x10 = 10.1m;
            decimal y10 = decimal.MaxValue; // 79228162514264337593543950335
            decimal a10 = decimal.MinValue; // -79228162514264337593543950335
            Console.WriteLine(x10);
            Console.WriteLine(y10);
            Console.WriteLine(a10);

            Console.WriteLine();
            Console.WriteLine("Char:");
            char letra1 = 'A';
            char letra2 = 'B';
            Console.WriteLine(letra1);
            Console.WriteLine(letra2);


            Console.WriteLine();
            Console.WriteLine("Boolean:");
            Boolean _true = true;
            Boolean _false = false;
            Console.WriteLine(_true);
            Console.WriteLine(_false);

            Console.WriteLine();
            Console.WriteLine("String:");
            Console.WriteLine("Hello World!");

            Console.WriteLine();
            Console.WriteLine("Object é a classe/tipo generica. Todas as classes se derivam dela:");
            object letras = "Oi";
            object numeros = "4.5f";
            Console.WriteLine(letras);
            Console.WriteLine(numeros);
        }
    }
}