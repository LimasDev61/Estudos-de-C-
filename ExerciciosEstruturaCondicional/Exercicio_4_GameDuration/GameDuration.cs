using System;

namespace Exercicio_4_GameDuration
{
    class GameDuration
    {
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