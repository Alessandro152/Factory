using Factory.Factory;
using Factory.Veiculo;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoFactory produto = null;

            produto = new VolkswagenFactory("12km/L", "60cv");

            var foda = produto.RetornarInformacoesCarro();

            Console.WriteLine($" Informações do veiculo : {foda.Modelo} {foda.Consumo} {foda.Potencia}");
            Console.ReadKey();
        }
    }
}
