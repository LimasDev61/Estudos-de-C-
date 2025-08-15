using System.Globalization;

namespace PropertiesProject;

public class PropClass
{
    private string _name;
    private double _price;
    public int Quantity { get; private set; } // auto-properties

    public string Name
    {
        get => _name; // => funciona como return;
        set => _name = !string.IsNullOrEmpty(value) ? value : _name;
    }

    public PropClass()
    {
        Quantity = 0;
    }

    public PropClass(string name, double price) : this()
    {
        Name = name;
        Price = price;
    }

    public double ValueTotalInStock => Price * Quantity;

    public double Price
    {
        get => _price;
        set => _price = value > 0 ? value : _price;
    }

    public void AddStock(int addStock)
    {
        if (addStock > 0)
        {
            Quantity += addStock;
        }
    }

    public void RemoveStock(int removeStock)
    {
        if (removeStock > 0)
        {
            Quantity -= removeStock;
        }
    }
    public override string ToString()
    {
        return Name
               + ", $ "
               + Price.ToString("F2", CultureInfo.InvariantCulture)
               + ", "
               + Quantity
               + " Unidades, Total: $ "
               + ValueTotalInStock.ToString("F2", CultureInfo.InvariantCulture);
    }
}