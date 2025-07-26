using System;
using System.Globalization;

namespace Exercicio_5_Table
{
    class Table
    {
        static void Main(string[] args)
        {
            
            string[] valores = Console.ReadLine().Split(' ');
            
            int codigo = Convert.ToInt32(valores[0]);
            int quantidade = Convert.ToInt32(valores[1]);

            double total = 0.0;
            if (codigo == 1)
            {
                total = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00;
            }
            else if (codigo == 5)
            {
                total = quantidade * 1.50;
            }
            else
            {
                Console.WriteLine("Código Inválido");
            }

            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

