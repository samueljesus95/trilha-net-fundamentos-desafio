using DesafioFundamentos.Models;

namespace DesafioFundamentos.Service
{
    public class AlocacaoService
    {
        public Estacionamento IniciarPrograma()
        {
            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                "Digite o preço inicial:");
            decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite o preço por hora:");
            decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

            // Instancia a classe Estacionamento, já com os valores obtidos anteriormente
            return new Estacionamento(precoInicial, precoPorHora);
        }

        public void Menu(Estacionamento estacionamento, EstacionamentoService estacionamentoService)
        {
            bool exibirMenu = true;

            // Realiza o loop do menu
            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        estacionamentoService.AdicionarVeiculo(estacionamento);
                        break;

                    case "2":
                        estacionamentoService.RemoverVeiculo(estacionamento);
                        break;

                    case "3":
                        estacionamentoService.ListarVeiculos(estacionamento);
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }
            Console.WriteLine("O programa se encerrou");
        }
    }
}