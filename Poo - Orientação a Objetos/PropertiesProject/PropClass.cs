using System.Globalization;

namespace PropertiesProject;

public class PropClass
{
    private string _name;
    private double _price;
    private int _quantity;

    public string Name
    {
        get => _name; // => funciona como return;
        set => _name = !string.IsNullOrEmpty(value) ? value : _name;
    }

    public double Price
    {
        get => _price;
        set => _price = value > 0 ? value : _price;
    }

    public int Quantity
    {
        get => _quantity;
    }

    public PropClass()
    {
        _quantity = 5;
    }

    public PropClass(string name, double price) : this()
    {
        _name = name;
        _price = price;
    }

    public double ValueTotalInStock => _price * _quantity; // virou uma propriedade!

    public void AddStock(int addStock)
    {
        if (addStock > 0)
        {
            _quantity += addStock;
        }
    }

    public void RemoveStock(int removeStock)
    {
        if (removeStock > 0)
        {
            _quantity -= removeStock;
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