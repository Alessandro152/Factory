using Factory.Produto.Veiculo;
using System;

namespace Factory.Factory
{
    public abstract class ProdutoFactory
    {
        public abstract Carro RetornarInformacoesCarro();
    }
}
