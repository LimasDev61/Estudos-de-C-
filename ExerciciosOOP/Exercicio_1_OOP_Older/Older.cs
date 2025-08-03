using System;

namespace Exercicio_1_OOP_Older;

class Older
{
    static void Main(string[] args)
    {
        OlderClass addUser1 = new OlderClass();
        OlderClass addUser2 = new OlderClass();

        Console.WriteLine("Dados da primeira pessoa:");
        Console.Write("Nome: ");
        addUser1.Name = Console.ReadLine();
        Console.Write("Idade: ");
        bool enterAge1 = int.TryParse(Console.ReadLine(), out addUser1.Age);

        Console.WriteLine("Dados da segunda pessoa:");
        Console.Write("Nome: ");
        addUser2.Name = Console.ReadLine();
        Console.Write("Idade: ");
        bool enterAge2 = int.TryParse(Console.ReadLine(), out addUser2.Age);

        Console.WriteLine($"\nDados da primeira pessoa:");
        Console.Write($"Nome: {addUser1.Name}");
        Console.WriteLine($"\nIdade: {addUser1.Age}");

        Console.WriteLine($"\nDados da segunda pessoa:");
        Console.Write($"Nome: {addUser2.Name}");
        Console.WriteLine($"\nIdade: {addUser2.Age}");

        if (addUser1.Age > addUser2.Age)
        {
            Console.Write($"\nPessoa mais velha: {addUser1.Name}");
        }
        else if (addUser1.Age < addUser2.Age)
        {
            Console.Write($"\nPessoa mais velha: {addUser2.Name}");
        }
        else
        {
            Console.WriteLine("\nEles possuem a mesma idade");
        }
    }
}