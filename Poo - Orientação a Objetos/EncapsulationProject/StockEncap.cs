using System.Globalization;

namespace EncapsulationProject;

class StockEncap
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados do produto:");
        Console.Write("Nome: ");
        string name = Console.ReadLine();

        Console.Write("Preço: ");
        bool value = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out double price);

        EncapClass stock = new EncapClass();

        stock.SetNome(name);
        stock.SetPrice(price);
        Console.WriteLine(stock);

        Console.WriteLine();
        Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
        bool valid = int.TryParse(Console.ReadLine(), out int numero);
        stock.AdicionarEstoque(numero);
        Console.WriteLine();
        Console.WriteLine($"Dados do produto: {stock}");
        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
        bool valid2 = int.TryParse(Console.ReadLine(), out int numero2);
        stock.RemoverEstoque(numero2);
        Console.WriteLine();
        Console.WriteLine($"Dados do produto: {stock}");
    }
}