using System.Globalization;

namespace PalavraThis;

class ThisWord
{
    static void Main(string[] args)
    {
        // Cria um objeto usando o Construtor 1 (sem parâmetros)
        // A quantidade inicial é 10, e nome/preço são valores padrão.
        ThisWordClass produto1 = new ThisWordClass();
        Console.WriteLine("Objeto criado com o Construtor 1:");
        Console.WriteLine(produto1); // Output: , $ 0.00, 10 Unidades, Total: $ 0.00

        Console.WriteLine("------------------------------------------");

        // Cria um objeto usando o Construtor 2 (com nome e preço)
        // A quantidade inicial é 10, herdada do Construtor 1.
        ThisWordClass produto2 = new ThisWordClass("Mouse", 25.50);
        Console.WriteLine("Objeto criado com o Construtor 2:");
        Console.WriteLine(produto2); // Output: Mouse, $ 25.50, 10 Unidades, Total: $ 255.00

        Console.WriteLine("------------------------------------------");

        // Cria um objeto usando o Construtor 3 (com nome, preço e quantidade)
        // A quantidade inicial é 5, sobrescrevendo o valor 10.
        ThisWordClass produto3 = new ThisWordClass("Teclado", 80.00, 5);
        Console.WriteLine("Objeto criado com o Construtor 3:");
        Console.WriteLine(produto3); // Output: Teclado, $ 80.00, 5 Unidades, Total: $ 400.00

        Console.WriteLine("------------------------------------------");

        // Demonstrando os métodos AdicionarStock e RemoverStock
        Console.WriteLine("Adicionando 15 unidades ao 'produto3'...");
        produto3.AdicionarStock(15);
        Console.WriteLine("Estoque atualizado:");
        Console.WriteLine(produto3); // Output: Teclado, $ 80.00, 20 Unidades, Total: $ 1600.00

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Removendo 5 unidades do 'produto3'...");
        produto3.RemoverStock(5);
        Console.WriteLine("Estoque atualizado:");
        Console.WriteLine(produto3); // Output: Teclado, $ 80.00, 15 Unidades, Total: $ 1200.00
    }
}