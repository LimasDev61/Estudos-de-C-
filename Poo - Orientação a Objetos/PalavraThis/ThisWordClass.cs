using System.Globalization;

namespace PalavraThis;

public class ThisWordClass
{
    public string Name;
    public double Price;
    public int Quantity;

    // Construtor principal (ou padrão, se você preferir)
    // Inicializa todos os campos
    public ThisWordClass()
    {
        Quantity = 10;
    }

    // Sobrecarga 1: Construtor com dois parâmetros (nome e preço).
    // Usa 'this' para chamar o construtor principal, dentro dele.
    public ThisWordClass(string name, double price) : this()
    {
        Name = name;
        Price = price;
    }

    // Com todos os argumentos.
    public ThisWordClass(string name, double price, int quantity) : this(name, price)
    {
        Quantity = quantity;
    }

    public double ValueTotalInStock()
    {
        return Price * Quantity;
    }

    public void AdicionarStock(int quantity)
    {
        Quantity += quantity;
    }

    public void RemoverStock(int quantity)
    {
        Quantity -= quantity;
    }

    public override string ToString()
    {
        return Name
               + ", $ "
               + Price.ToString("F2", CultureInfo.InvariantCulture)
               + ", "
               + Quantity
               + " Unidades, Total: $ "
               + ValueTotalInStock().ToString("F2", CultureInfo.InvariantCulture);
    }
}