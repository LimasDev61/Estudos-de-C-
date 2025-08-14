using System.Globalization;

namespace PropertiesProject;

class StockProp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados do produto:");
        Console.Write("Nome: ");
        string name = Console.ReadLine();
        
        Console.Write("Preço: ");
        bool value = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out double price);

        PropClass stock = new PropClass();
        
        stock.Name = name;
        stock.Price = price;
        
        Console.WriteLine();
        Console.WriteLine($"Dados do produto: {stock}");
        Console.WriteLine();

        Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
        bool valid = int.TryParse(Console.ReadLine(), out int numero);
        stock.AddStock(numero);
        Console.WriteLine();
        Console.WriteLine($"Dados do produto: {stock}");
        Console.WriteLine();

        Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
        bool valid2 = int.TryParse(Console.ReadLine(), out int numero2);
        stock.RemoveStock(numero2);
        Console.WriteLine();
        Console.WriteLine($"Dados do produto: {stock}");
    }
}