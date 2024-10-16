using LojaVirtual.Core.Contrato;

namespace LojaVirtual.Core
{
    internal class Eletronico : IDesconto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Eletronico(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public decimal AplicarDesconto(decimal preco)
        {
            return preco * 0.90m;
        }

        public decimal CalcularPrecoComDesconto()
        {
            return AplicarDesconto(Preco);
        }
    }
}
