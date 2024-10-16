using LojaVirtual.Core;
using LojaVirtual.Core.Contrato;

namespace LojaVirtual.Service
{
    internal class DescontoService
    {
        public void AplicarDescontoEmProdutos(List<IDesconto> produtos)
        {
            foreach (var produto in produtos)
            {
                
                if (produto is Eletronico eletronico)
                {
                    decimal precoComDesconto = eletronico.CalcularPrecoComDesconto();
                    Console.WriteLine($"Produto: {eletronico.Nome}, Preço original: {eletronico.Preco}, Preço com desconto: {precoComDesconto}");
                }
                else if (produto is Roupa roupa)
                {
                    decimal precoComDesconto = roupa.CalcularPrecoComDesconto();
                    Console.WriteLine($"Produto: {roupa.Nome}, Preço original: {roupa.Preco}, Preço com desconto: {precoComDesconto}");
                }
            }
        }
    }
}
