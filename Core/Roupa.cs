using LojaVirtual.Core.Contrato;

namespace LojaVirtual.Core
{
    internal class Roupa : IDesconto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Roupa(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public decimal AplicarDesconto(decimal preco)
        {
            return preco * 0.80m; 
        }

        public decimal CalcularPrecoComDesconto()
        {
            return AplicarDesconto(Preco);
        }
    }
}
