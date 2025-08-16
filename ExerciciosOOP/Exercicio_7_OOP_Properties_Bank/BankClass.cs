using System.Globalization;

namespace Exercicio_7_OOP_Properties_Bank;

public class BankClass
{
    public int Account { get; }
    private string _name;
    public double Deposit { get; private set; }

    public BankClass()
    {
        Deposit = 0.0;
    }

    public BankClass(int account, string name) : this()
    {
        Name = name;
        string accountString = account.ToString();
        if (account > 0 && accountString.Length >= 4)
        {
            Account = account;
        }
    }

    public string Name
    {
        get => _name;
        set => _name = !string.IsNullOrEmpty(value) ? value : _name;
    }

    public void DepositCash(double amount)
    {
        if (amount >= 0.0)
        {
            Deposit += amount;
        }
    }

    public bool WithdrawCash(double amount)
    {
        double tax = 5.0;
        double totalAmount = amount + tax;
        if (amount >= 0.0 && amount <= Deposit)
        {
            Deposit -= totalAmount;
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return $"Conta: {Account}, "
               + $"Titular: {Name}, "
               + $"Saldo: $ {Deposit.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}

// obs: quando tiver um construtor para a lógica do deposito, chame a função e bote o parametro dentro,
// exemplo: public ContaBancaria(int numero, string titular, double depositoInicial) this(numero, titular) {
//      DepositCash(depositoInicial);
//}