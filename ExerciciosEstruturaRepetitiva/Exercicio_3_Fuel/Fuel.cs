using System;

namespace Exercicio_3_Fuel
{
    class Fuel
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            bool numero = int.TryParse(Console.ReadLine(), out int order);
            while (order != 4)
            {
                if (order == 1)
                {
                    alcool++;
                }
                else if (order == 2)
                {
                    gasolina++;
                }
                else if (order == 3)
                {
                    diesel++;
                }

                int.TryParse(Console.ReadLine(), out order);
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}