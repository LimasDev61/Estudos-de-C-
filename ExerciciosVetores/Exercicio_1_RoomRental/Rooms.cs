namespace Exercicio_1_RoomRental;

class Rooms
{
    static void Main(string[] args)
    {
        Pensionato meuPensionato = new Pensionato();
        Console.Write("Registrar a quantidade de quartos para aluguel: ");
        int totalDeQuartos = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < totalDeQuartos; i++)
        {
            Console.WriteLine($"\nRegistro #{i + 1}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Quartos de 1 a 10: ");
            int numeroDeQuartos = Convert.ToInt32(Console.ReadLine());
            ;
            
            int indiceDoQuarto = numeroDeQuartos - 1;

            meuPensionato.AlugarQuartos(indiceDoQuarto, nome, email);
        }

        meuPensionato.Relatorio();
    }
}