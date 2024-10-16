using LojaVirtual.Core;
using LojaVirtual.Core.Contrato;
using LojaVirtual.Service;

List<IDesconto> produtos = new List<IDesconto>
{
    new Eletronico("Play Station 9", 10000.00m),
    new Roupa("Cuequinha Homem Aranha", 100.00m)
};

DescontoService descontoService = new DescontoService();
descontoService.AplicarDescontoEmProdutos(produtos);
