namespace Exercicio_1_RoomRental;

public class Pensionato
{
    private Estudante[] _quartos;

    public Pensionato()
    {
        _quartos = new Estudante[10];
    }

    public void AlugarQuartos(int numeroQuartos, string nome, string email)
    {
        _quartos[numeroQuartos] = new Estudante(nome, email);
    }

    public void Relatorio()
    {
        Console.WriteLine("\n--- Relátorio de Ocupações: ");

        for (int i = 0; i < _quartos.Length; i++)
        {
            if (_quartos[i] != null)
            {
                Console.WriteLine($"Quarto {i}: {_quartos[i]}");
            }
            else
            {
                Console.WriteLine($"Quarto {i}: Vázio");
            }
        }
    }
}