using System.Globalization;

namespace PropertiesProject;

class StockProp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados do produto:");
        Console.Write("Nome: ");
        string name = Console.ReadLine();

        double price;
        bool priceIsValid;

        do
        {
            Console.Write("Preço: ");
            priceIsValid = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
                out price);

            if (!priceIsValid || price <= 0.0)
            {
                Console.WriteLine("Insira o valor do produto válido.");
                priceIsValid = false;
            }
            
        } while (!priceIsValid);

        PropClass stock = new PropClass(name, price);
        
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine($"Digite o número de produto(os) {stock.Name} a ser adicionado ao estoque:");
        bool valid = int.TryParse(Console.ReadLine(), out int numero);
        stock.AddStock(numero);
        Console.WriteLine();
        Console.WriteLine($"Dados do produto: {stock}");
        Console.WriteLine();

        Console.WriteLine($"Digite o número de produto(os) {stock.Name} a ser removido do estoque:");
        bool valid2 = int.TryParse(Console.ReadLine(), out int numero2);
        stock.RemoveStock(numero2);
        Console.WriteLine();
        Console.WriteLine($"Dados do produto: {stock}");
    }
}