namespace Exercicio_1_RoomRental;

public class Estudante
{
    public string Nome { get; }
    public string Email { get; }

    public Estudante(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Email: {Email}";
    }
}