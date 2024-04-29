using System.Security.Cryptography.X509Certificates;
using DesafioFundamentos.Models;

namespace DesafioFundamentos.Service
{
    public class EstacionamentoService
    {
        public void AdicionarVeiculo(Estacionamento estacionamento)
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placaVeiculo = Console.ReadLine();
            estacionamento.veiculos.Add(placaVeiculo.ToUpper());
        }

        public void RemoverVeiculo(Estacionamento estacionamento)
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            var placaVeiculo = Console.ReadLine();

            var veiculo = BuscarVeiculo(estacionamento, placaVeiculo);
            if (veiculo != null)
            {
                var valorTotal = CalcularHoras(estacionamento);
                estacionamento.veiculos.Remove(veiculo);
                Console.WriteLine($"O veículo {veiculo} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos(Estacionamento estacionamento)
        {
            if (estacionamento.veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string veiculo in estacionamento.veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public static string BuscarVeiculo(Estacionamento estacionamento, string placa)
        {
            return estacionamento.veiculos.Find(x => x.ToUpper() == placa.ToUpper());
        }

        public static decimal CalcularHoras(Estacionamento estacionamento)
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            var qtdHorasEstacionado = int.Parse(Console.ReadLine());
            return estacionamento.precoInicial + estacionamento.precoPorHora * qtdHorasEstacionado;
        }
    }
}