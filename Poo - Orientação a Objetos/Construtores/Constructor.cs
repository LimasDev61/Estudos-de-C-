using System.Globalization;

namespace Construtores;

public class StockClass
{
    public string Name;
    public double Price;
    public int Quantity;

    // Construtor com Parâmetros
    public StockClass(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
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