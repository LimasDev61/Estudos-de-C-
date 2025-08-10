using System.Globalization;

namespace Sobrecarga;

class SobrecargaOOP
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Entre com os dados do produto:");
        Console.Write("Nome: ");
        string name = Console.ReadLine();

        Console.Write("Preço: ");
        bool value = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
            out double price);
        
        // Utilizando o construtor com dois argumentos, mas caso eu queria utilizar com três argumentos, basta eu apenas especificar
        // no SobrecargaProduto(name, price, 20);
        SobrecargaProduto stock = new SobrecargaProduto(name, price);
        SobrecargaProduto stock1 = new SobrecargaProduto(); // Chamada do construtor padrão, tipos números se iniciam em 0, tipo string em null;

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