namespace Fundamentos;

internal class Program
{
    static void Main()
    {
        int opcao;
        Estacionamento Veiculo = new Estacionamento();

        do
        {
            Console.WriteLine("1. Cadastrar Veículo.\n" +
                              "2. Remover Veículo\n" +
                              "3. Listar Veículo\n" +
                              "4. Encerrar");
            Console.WriteLine();

            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Veiculo.AdicionarVeiculo();
                    break;

                case 2:
                    Veiculo.RemoverVeiculo();
                    break;

                case 3:
                    Veiculo.ListarVeiculos();
                    break;

                case 4:
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 4);
    }
}