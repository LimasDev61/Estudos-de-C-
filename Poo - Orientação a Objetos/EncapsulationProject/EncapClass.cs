using System.Globalization;

namespace EncapsulationProject;

public class EncapClass
{
    private string _name;
    private double _price;
    private int _quantity;

    public EncapClass()
    {
        _quantity = 0;
    }

    public EncapClass(string name, double price) : this()
    {
        _name = name;
        _price = price;
    }

    public string GetNome()
    {
        return _name;
    }

    public void SetNome(string name)
    {
        if (name != null && name.Length > 0)
        {
            _name = name;
        }
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        if (price > 0.0)
        {
            _price = price;
        }
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double ValueTotalInStock()
    {
        return _price * _quantity;
    }

    public void AdicionarEstoque(int addStock)
    {
        _quantity += addStock;
    }

    public void RemoverEstoque(int removeStock)
    {
        _quantity -= removeStock;
    }

    public override string ToString()
    {
        return GetNome()
               + ", $ "
               + GetPrice().ToString("F2", CultureInfo.InvariantCulture)
               + ", "
               + GetQuantity()
               + " Unidades, Total: $ "
               + ValueTotalInStock().ToString("F2", CultureInfo.InvariantCulture);
    }
}