using LojaVirtual.Core;
using LojaVirtual.Core.Contrato;
namespace LojaVirtual.Service
{
    internal class DescontoService
    {
        public void AplicarDescontoEmProdutos(List<Produto> produtos)
        {
            foreach (var produto in produtos)
            {
                decimal precoComDesconto = produto.CalcularPrecoComDesconto();
                Console.WriteLine($"Produto: {produto.Nome}, Preço original: {produto.Preco}, Preço com desconto: {precoComDesconto}");
            }
        }
    }
}
