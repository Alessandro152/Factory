using Factory.Factory;
using Factory.Produto.Veiculo;
using Factory.Produto.VolkswagenVeiculos;

namespace Factory.Veiculo
{
    public class VolkswagenFactory : ProdutoFactory 
    {
        private string _modelo;

        public VolkswagenFactory(string modelo)
        {
            _modelo = modelo;
        }

        public override Carro RetornarInformacoesCarro()
        {
            return new Volkswagen(_modelo);
        }
    }
}
