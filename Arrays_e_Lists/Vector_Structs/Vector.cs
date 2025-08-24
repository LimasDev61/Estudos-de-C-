using System.Globalization;

namespace Vector_Structs;

class Vector
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual o tamanho do seu vetor?");
        bool indices = int.TryParse(Console.ReadLine(), out int n);

        if (indices && n > 0)
        {
            double[] alturas = new double[n];

            Console.WriteLine($"Digite {n} alturas:");
            for (int i = 0; i < alturas.Length; i++)
            {
                bool valid = double.TryParse(
                    Console.ReadLine(),
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out double valor);

                if (valid)
                {
                    alturas[i] = valor;
                }
                else
                {
                    Console.WriteLine("Valor inválido, insira novamente.");
                    i--;
                }
            }

            Console.WriteLine("Essa foram as alturas inseridas:");
            foreach (double altura in alturas)
            {
                Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}