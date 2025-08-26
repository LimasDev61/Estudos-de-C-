namespace Params_Modifier;

class Program
{
    static void Main(string[] args)
    {
        int result = 0;
        int ordem = 1;

        Console.WriteLine("Caso queira sair do programa, digite 0, ou qualquer Letra");
        Console.WriteLine($"Digite o {ordem}º numero para somar:");
        bool valid = int.TryParse(Console.ReadLine(), out int n);

        while (valid && n > 0)
        {
            result += Calculator.Sum(n);
            ordem++;
            Console.WriteLine($"Digite o {ordem}º numero para somar:");
            int.TryParse(Console.ReadLine(), out n);
        }

        Console.WriteLine($"\nTotal da Soma: {result}");
    }
}