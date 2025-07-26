using System;

namespace Exercicio_4_GameDuration
{
    class GameDuration
    {
        /*
         * 
         * Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o
         * mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de
         * 24 horas.
         * 
         */
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = Convert.ToInt32(valores[0]);
            int horaFinal = Convert.ToInt32(valores[1]);

            int duracao;

            if (horaFinal > horaInicial)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}