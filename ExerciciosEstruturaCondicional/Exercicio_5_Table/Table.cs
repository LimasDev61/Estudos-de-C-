using System;
using System.Globalization;

namespace Exercicio_5_Table
{
    class Table
    {
        /*
         * 
         * Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
         * A seguir, calcule e mostre o valor da conta a pagar.
         *
         * CODIGO	ESPECIFICAÇÃO	PREÇO
         * 1	Cachorro Quente	R$ 4.00
         * 2	X-Salada	R$ 4.50
         * 3	X-Bacon	R$ 5.00
         * 4	Torrada simples	R$ 2.00
         * 5	Refrigerante	R$ 1.50
         * 
         */
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

