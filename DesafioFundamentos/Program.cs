using DesafioFundamentos.Models;
using DesafioFundamentos.Service;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

AlocacaoService alocacaoService = new AlocacaoService();
EstacionamentoService estacionamentoService = new EstacionamentoService();

Estacionamento estacionamento = alocacaoService.IniciarPrograma();
alocacaoService.Menu(estacionamento, estacionamentoService);
