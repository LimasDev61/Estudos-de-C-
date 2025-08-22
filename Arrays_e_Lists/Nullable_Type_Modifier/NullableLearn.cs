namespace Nullable_Type_Modifier;

class NullableLearn
{
    static void Main(string[] args)
    {
        double? x = null; // type struct nullable

        // null coalescing
        double verify = x ?? 0; // equivalente ao if / else;

        Console.WriteLine($"x = {verify}"); // Saída 0; true = numero, false = null


        // os três métodos de nullable
        double? y = 10.0;

        // Método GetValueOrDefault, pega sempre o valor padrão da variável.
        Console.WriteLine(x.GetValueOrDefault());
        Console.WriteLine(y.GetValueOrDefault());

        // Método HasValue, verifica se as nullable são vardadeiro ou falso.
        Console.WriteLine(x.HasValue); // não tem valor é false
        Console.WriteLine(y.HasValue); // tem valor é true;

        // Value, pega o valor diretamente da variável, não é um método e só funciona com a verificação do HasValue;

        if (x.HasValue)
        {
            Console.WriteLine(x.Value);
        }
        else
        {
            Console.WriteLine("X, é NULO");
        }

        if (y.HasValue)
        {
            Console.WriteLine(y.Value);
        }
        else
        {
            Console.WriteLine("Y, é  NULO");
        }
        // x.Value, tem exceção quando lançado sozinho por se tratar de um valor nulo.
    }
}