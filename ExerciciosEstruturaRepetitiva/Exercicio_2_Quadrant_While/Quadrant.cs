using System;

namespace Exercicio_2_Quadrant_While
{
    class Quadrant
    {
        /*
         *
         * Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
         * cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
         * menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
         * 
         */
        static void Main(string[] args)
        {
            string[] confirm = Console.ReadLine().Split(' ');
            int quadrantX = Convert.ToInt32(confirm[0]);
            int quadrantY = Convert.ToInt32(confirm[1]);

            while (quadrantX != 0 && quadrantY != 0)
            {
                if (quadrantX == quadrantY)
                {
                    Console.WriteLine("primeiro");
                }
                else if (quadrantX < 0 && quadrantY > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (quadrantX < 0 && quadrantY < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }

                confirm = Console.ReadLine().Split(' ');
                quadrantX = Convert.ToInt32(confirm[0]);
                quadrantY = Convert.ToInt32(confirm[1]);
            }
        }
    }
}