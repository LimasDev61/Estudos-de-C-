using System;

namespace Exercicio_1_Password_While
{
    class Password
    {
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