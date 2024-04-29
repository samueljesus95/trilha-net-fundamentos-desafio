namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal precoInicial = 0;
        public decimal precoPorHora = 0;
        public List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
    }
}
