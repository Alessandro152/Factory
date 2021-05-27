namespace Factory.Produto.Veiculo
{
    public abstract class Carro
    {
        public abstract string Modelo { get; }
        public abstract string Consumo { get; set; }
        public abstract string Potencia { get; set; }
    }
}
