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
        public static string Marca { get; private set; }
        public static string Modelo { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo! Selecione a marca e modelo do veículo que deseja informações: ");

            //Inicia o programa e solicita ao usuário a marca e modelo do veículo
            IniciarPrograma();

            //Buscar os dados do veiculo
            var dados = RetornarInformacoes(Convert.ToInt32(Marca), Modelo);

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

        private static Carro RetornarInformacoes(int marca, string modelo)
        {
            ProdutoFactory veiculo = null;

            switch (marca)
            {
                case (int)EVeiculoMarca.Volkswagen:
                    veiculo = new VolkswagenFactory(modelo);
                    break;
                case (int)EVeiculoMarca.Fiat:
                    veiculo = new FiatFactory(modelo);
                    break;
            }

            return veiculo.RetornarInformacoesCarro();
        }

        private static string RetornarMarcaVeiculos()
        {
            return new StringBuilder(@"Digite a marca do veículo :
                                     0 = Volkswagen
                                     1 = Fiat
                                     2 = Ford
                                     3 = Chevrolet
                                     9 = Sair do Programa").ToString();
        }

        private static string RetornarModeloVeiculos(int marca)
        {
            object texto = null;

            switch (marca)
            {
                case (int)EVeiculoMarca.Volkswagen:
                    texto = new StringBuilder(@"Digite a marca do veículo :
                                              0 = Apollo
                                              1 = Gol
                                              2 = Fusca
                                              3 = Passat
                                              9 = Sair do Programa").ToString();
                    break;
                default:
                    break;
            }

            return texto.ToString();
        }

        private static void IniciarPrograma()
        {
            //Marca do veiculo
            //var comboMarcaVeiculos = RetornarMarcaVeiculos();
            Console.WriteLine(RetornarMarcaVeiculos());
            Marca = Console.ReadLine();

            if (Marca == "9")
            {
                Environment.Exit(0);
            }

            //Modelo do veiculo
            //var opcaoModelo = RetornarModeloVeiculos(Convert.ToInt32(marca.Trim()));
            Console.Write(RetornarModeloVeiculos(Convert.ToInt32(Marca.Trim())));
            Modelo = Console.ReadLine();

            if (Modelo == "9")
            {
                Console.Clear();
                IniciarPrograma();
            }
        }
    }
}
