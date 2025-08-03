using System;
using System.Globalization;

namespace Resolucao_Estoque_Oop;

class Stock
{
    static void Main(string[] args)
    {
        StockClass stock = new StockClass();
        Console.WriteLine("Entre com os dados do produto:");
        Console.Write("Nome: ");
        stock.Name = Console.ReadLine();

        Console.Write("Preço: ");
        bool value = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out stock.Price);

        Console.Write("Quantidade: ");
        bool total = int.TryParse(Console.ReadLine(), out stock.Quantity);

        Console.WriteLine();
        Console.WriteLine($"Dados do produto: {stock}");
        Console.WriteLine();

        Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
        bool valid = int.TryParse(Console.ReadLine(), out int numero);
        stock.AdicionarStock(numero);
        Console.WriteLine();
        Console.WriteLine($"Dados do produto: {stock}");
        Console.WriteLine();

        Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
        bool valid2 = int.TryParse(Console.ReadLine(), out int numero2);
        stock.RemoverStock(numero2);
        Console.WriteLine();
        Console.WriteLine($"Dados do produto: {stock}");
    }
}