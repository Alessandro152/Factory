using Factory.Factory;
using Factory.Produto.Veiculo;
using Factory.Produto.VolkswagenVeiculos;

namespace Factory.Veiculo
{
    public class VolkswagenFactory : ProdutoFactory 
    {
        private string _consumo;
        private string _potencia;

        public VolkswagenFactory(string consumo, string potencia)
        {
            _consumo = consumo;
            _potencia = potencia;
        }

        public VolkswagenFactory()
        {
        }

        public override Carro RetornarInformacoesCarro(string modelo)
        {
            return new Volkswagen(modelo);
        }

        public override Carro RetornarInformacoesCarro()
        {
            return new Volkswagen(_consumo, _potencia);
        }
    }
}
