using LojaVirtual.Core;
using LojaVirtual.Service;

List<Produto> produtos = new List<Produto>
            {
                new Eletronico("Smartphone", 1500.00m),
                new Roupa("Camiseta", 100.00m)
            };

DescontoService descontoService = new DescontoService();
descontoService.AplicarDescontoEmProdutos(produtos);
