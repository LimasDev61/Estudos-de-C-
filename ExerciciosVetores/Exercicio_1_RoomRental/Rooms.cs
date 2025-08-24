namespace Exercicio_1_RoomRental;

class Rooms
{
    /*
     * A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos identificados pelos
     * números 1 a 10. Quando um estudante deseja alugar um quarto, deve-se registrar o nome e e-mail deste estudante.
     * Fazer um programa que inicie com todos os dez quartos vazios, e depois leia uma quantidade N representando o
     * número de estudantes que vão alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos N
     * estudantes.
     * Para cada registro de aluguel, informar o nome e e-mail do estudante, bem como qual dos quartos ele escolheu
     * (de 1 a 10). Suponha que seja escolhido um quarto vago. Ao final, seu programa deve imprimir um relatório de todas
     * ocupações do pensionato, por ordem de quarto.
     */
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