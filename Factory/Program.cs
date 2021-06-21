using Factory.Factory;
using Factory.Produto.FiatVeiculos;
using Factory.Produto.Veiculo;
using Factory.Veiculo;
using System;
using System.Text;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Marca do veiculo
            Console.Write("Informe a marca do veículo: ");
            string marca = Console.ReadLine();

            //Modelo do veiculo
            Console.Write("Informe o modelo do veículo: ");
            string modelo = Console.ReadLine();

            //Buscar os dados do veiculo
            var dados = RetornarInformacoes(marca, modelo);

            if (dados != null)
            {
                var texto = new StringBuilder($" Informações do veiculo : " +
                                              $"Modelo: {dados.Modelo}, " +
                                              $"Consumo: {dados.Consumo}, " +
                                              $"Potência: {dados.Potencia}");
                Console.WriteLine(texto);
                Console.ReadKey();
            }
            
        }

        private static Carro RetornarInformacoes(string marca, string modelo)
        {
            ProdutoFactory veiculo = null;

            switch (marca.ToLower())
            {
                case "volkswagen":
                    veiculo = new VolkswagenFactory(modelo);
                    break;
                case "fiat":
                    veiculo = new FiatFactory(modelo);
                    break;
            }

            return veiculo.RetornarInformacoesCarro();
        }
    }
}
