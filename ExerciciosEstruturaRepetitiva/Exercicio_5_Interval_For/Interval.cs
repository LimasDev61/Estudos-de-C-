using System;

namespace Exercicio_5_Interval_For
{
    class Interval
    {
        /*
         *
         * Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
         * mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
         * essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). 
         * 
         */
        static void Main(string[] args)
        {
            int _in = 0;
            int _out = 0;

            bool confirm = int.TryParse(Console.ReadLine(), out int quantidade);

            for (int i = 0; i < quantidade; i++)
            {
                int.TryParse(Console.ReadLine(), out int interval);

                if (interval >= 10 && interval <= 20)
                {
                    _in++;
                }
                else
                {
                    _out++;
                }
            }

            Console.WriteLine($"{_in} in");
            Console.WriteLine($"{_out} out");
        }
    }
}