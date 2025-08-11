using System.Globalization;

namespace SintaxeAlternativaIniciarValores;

class Alternative
{
    static void Main(string[] args)
    {
        AlternativeClass stock1 = new AlternativeClass()
        {
            Name = "TV",
            Price = 900.00,
            Quantity = 5
        };

        AlternativeClass stock2 = new AlternativeClass
        {
            Name = "TV",
            Price = 900.00,
            Quantity = 5
        };

        Console.WriteLine("Entre com os dados do produto:");
        Console.Write("Nome: ");
        string name = Console.ReadLine();

        Console.Write("Preço: ");
        bool value = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out double price);

        Console.Write("Quantidade: ");
        bool total = int.TryParse(Console.ReadLine(), out int quantity);

        AlternativeClass stock = new AlternativeClass(name, price, quantity);

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
        Console.WriteLine();
        Console.WriteLine("Chamada para o objeto com sintaxe alternativa para inicialização de valores:");
        Console.WriteLine($"Dados do produto: {stock1}");
        Console.WriteLine($"Dados do produto: {stock2}");
    }
}