using Factory.Factory;
using Factory.Produto.Veiculo;

namespace Factory.Produto.FiatVeiculos
{
    internal class FiatFactory : ProdutoFactory
    {
        private string _modelo;

        public FiatFactory(string modelo)
        {
            _modelo = modelo;
        }

        public override Carro RetornarInformacoesCarro()
        {
            throw new System.NotImplementedException();
        }
    }
}