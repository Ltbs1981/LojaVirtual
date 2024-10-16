using LojaVirtual.Core.Contrato;

namespace LojaVirtual.Core
{
    internal class Roupa : Produto, IDesconto
    {
        public Roupa(string nome, decimal preco) : base(nome, preco) { }

        public decimal AplicarDesconto(decimal preco)
        {
            return preco * 0.80m; 
        }

        public override decimal CalcularPrecoComDesconto()
        {
            return AplicarDesconto(Preco);
        }
    }
}
