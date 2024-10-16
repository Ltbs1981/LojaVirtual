namespace LojaVirtual.Core
{
    internal abstract class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public abstract decimal CalcularPrecoComDesconto();
    }
}
}
