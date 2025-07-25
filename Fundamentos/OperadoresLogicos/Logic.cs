using System;

namespace OperadoresLogicos
{
    class Logic
    {
        static void Main(string[] args)
        {
            // Operador AND(&&)
            bool condicao1 = 2 > 3 && 4 != 5;
            Console.WriteLine("Condicao 1, operador AND, 2 > 3 && 4 != 5: " + condicao1);

            // Operador OR(||)
            bool condicao2 = 2 > 3 || 4 != 5;
            Console.WriteLine("Condicao 2, operador OR, 2 > 3 || 4 != 5: " + condicao2);

            // Teste de precedência 
            bool condicao3 = 10 < 5;
            bool condicao4 = condicao1 || condicao2 && condicao3;
            Console.WriteLine("Teste de precedência, false || true && false = resultado, false: " + condicao4);

            // Primeiro resolve condicao2 && condicao3 → true && false = false
            // Depois resolve condicao1 || false → false || false = false

            // Operador NOT (!)
            bool condicao5 = !(4 == 4);
            Console.WriteLine("Condicao 5, operador NOT, !(4 == 4): " + condicao5);

            // Outro exemplo com NOT e uma variável
            bool estaChovendo = false;
            bool sairDeCasa = !estaChovendo;
            Console.WriteLine("Condicao 6, operador NOT, !estaChovendo: " + sairDeCasa);
        }
    }
}