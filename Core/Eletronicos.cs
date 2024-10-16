using LojaVirtual.Core.Contrato;

namespace LojaVirtual.Core
{
    internal class Eletronicos: Produto, IDesconto
    {
        public class Eletronico : Produto, IDesconto
        {
            public Eletronico(string nome, doublepreco) : base(nome, preco) { }

            public decimal AplicarDesconto(decimal preco)
            {
                return preco * 0.90m; // 10% de desconto
            }

            public override decimal CalcularPrecoComDesconto()
            {
                return AplicarDesconto(Preco);
            }
        }
    }
