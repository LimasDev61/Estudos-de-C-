using System.Globalization;

namespace Exercicio_7_OOP_Properties_Bank;

class Bank
/*
 * 
 */
{
    static void Main(string[] args)
    {
        int accountNumber;
        bool accountValid;
        string userValid;
        Console.Write("Bem vindo ao sistema do Banco Lizarb: ");

        do
        {
            Console.Write("Por favor, digite o número da conta (4 ou mais dígitos): ");
            string input = Console.ReadLine();
            accountValid = int.TryParse(input, out accountNumber) && input.Length >= 4;
            if (!accountValid)
            {
                Console.WriteLine("Entrada inválida, tente novamente!");
            }
        } while (!accountValid);

        do
        {
            Console.Write("Entre com o nome do titular da conta: ");
            userValid = Console.ReadLine();
        } while (string.IsNullOrEmpty(userValid) || userValid.Any(char.IsDigit));

        BankClass bank = new BankClass(accountNumber, userValid);

        Console.WriteLine("Sua conta foi criada com sucesso!");
        Console.WriteLine($"Informações da conta: {bank} ");

        Console.WriteLine();
        Console.Write("Deseja fazer depósito? S/N: ");
        char userInput = Console.ReadLine().ToUpper()[0];

        double amount;
        bool transationValid;
        if (userInput == 'S')
        {
            do
            {
                Console.Write("Entre com o valor do depósito: ");
                transationValid = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
                    out amount);

                Console.WriteLine();

                if (!transationValid)
                {
                    Console.WriteLine("Entre apenas com valores númericos.");
                }
                else
                {
                    bank.DepositCash(amount);
                    Console.WriteLine($"Valor depósitado: $ {amount.ToString("F2", CultureInfo.InvariantCulture)}");
                }
            } while (!transationValid);

            Console.WriteLine();
            Console.Write("Deseja fazer Saque? S/N: ");
            char userInputSaque = Console.ReadLine().ToUpper()[0];

            if (userInputSaque == 'S')
            {
                do
                {
                    Console.Write("Entre com o valor do Saque: ");
                    transationValid = double.TryParse(Console.ReadLine(), NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out amount);

                    Console.WriteLine();

                    if (!transationValid)
                    {
                        Console.WriteLine("Entre apenas com valores númericos.");
                    }
                    else
                    {
                        if (bank.WithdrawCash(amount))
                        {
                            Console.WriteLine(
                                $"Valor do Saque: $ {amount.ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente para saque!");
                        }
                    }
                } while (!transationValid);
            }

            Console.WriteLine($"Informações da conta atualizadas: {bank}");
            Console.WriteLine("Obrigado por utilizar nossos serviços, atenciosamente Lizarb Bank!");
        }
    }
}