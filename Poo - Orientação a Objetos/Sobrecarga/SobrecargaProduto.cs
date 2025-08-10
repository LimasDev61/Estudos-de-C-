using System.Globalization;
namespace Sobrecarga;

public class SobrecargaProduto
{
    public string Name;
    public double Price;
    public int Quantity;

    // Construtor com três Parâmetros
    public SobrecargaProduto(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    // Construtor com dois Parâmetros em sobrecarga
    public SobrecargaProduto(string name, double price)
    {
        Name = name;
        Price = price;
        Quantity = 10;
    }
    
    // Construtor sobrecarga padrão
    public SobrecargaProduto()
    {
        
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