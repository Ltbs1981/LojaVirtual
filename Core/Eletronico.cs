using LojaVirtual.Core.Contrato;

namespace LojaVirtual.Core
{
	internal class Eletronico : Produto, IDesconto
	{
		public Eletronico(string nome, decimal preco) : base(nome, preco) { }

		public decimal AplicarDesconto(decimal preco)
		{
			return preco * 0.90m;
		}

		public override decimal CalcularPrecoComDesconto()
		{
			return AplicarDesconto(Preco);
		}
	}
}
