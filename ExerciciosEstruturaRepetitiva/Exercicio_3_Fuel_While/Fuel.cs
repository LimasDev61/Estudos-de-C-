﻿using System;

namespace Exercicio_3_Fuel_While
{
    class Fuel
    {
        /*
         *
         * Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
         * um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
         * 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
         * que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
         * mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível,
         * 
         */
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