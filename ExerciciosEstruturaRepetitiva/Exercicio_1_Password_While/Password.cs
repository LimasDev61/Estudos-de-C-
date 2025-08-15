using System;

namespace Exercicio_1_Password_While
{
    class Password
    {
        /*
         * 
         * Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
         * incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
         * impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
         * 
         */
        static void Main(string[] args)
        {
            
            bool confirm = int.TryParse(Console.ReadLine(), out int num);

            while (num != 2002)
            {
                Console.WriteLine("Senha Inválida");
                int.TryParse(Console.ReadLine(), out num);
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}