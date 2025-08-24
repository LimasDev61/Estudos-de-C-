using System.Globalization;

namespace Vector_Class;

class Vector
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual o tamanho do seu vetor?");
        bool indices = int.TryParse(Console.ReadLine(), out int n);

        if (indices && n > 0)
        {
            ProductClass[] totalProdutos = new ProductClass[n];

            Console.WriteLine($"Digite {n} produtos para ser adicionados:");
            for (int i = 0; i < totalProdutos.Length; i++)
            {
                Console.WriteLine("Nome do Produto:");
                string produtoName = Console.ReadLine();

                Console.WriteLine("Valor do Produto:");
                bool valid = double.TryParse(
                    Console.ReadLine(),
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out double preco);

                if (valid && !string.IsNullOrWhiteSpace(produtoName))
                {
                    totalProdutos[i] = new ProductClass { Name = produtoName, Price = preco };
                }
                else
                {
                    Console.WriteLine("Valores inválidos, insira novamente.");
                    i--;
                }
            }

            Console.WriteLine("Esses foram os produtos inseridas:");
            foreach (ProductClass p in totalProdutos)
            {
                Console.WriteLine($"Nome do produto: {p.Name}, {p.Price.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine("Média dos produtos inseridos:");
            double total = 0.0;
            for (int i = 0; i < totalProdutos.Length; i++)
            {
                total += totalProdutos[i].Price;
            }

            double resultado = total / n;

            Console.WriteLine($"Média: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}