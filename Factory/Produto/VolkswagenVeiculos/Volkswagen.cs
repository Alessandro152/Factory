using Factory.Produto.Veiculo;
using System;
using System.Collections.Generic;

namespace Factory.Produto.VolkswagenVeiculos
{
    public class Volkswagen : Carro
    {
        private string _modelo;
        private string _consumo;
        private string _potencia;

        public Volkswagen(string modelo)
        {
            _modelo = modelo;
            _consumo = RetornarConsumo(_modelo);
            _potencia = RetornarPotencia(_modelo);
        }

        public override string Modelo { get { return _modelo; } }
        public override string Consumo { get { return _consumo; } set { _consumo = value; } }
        public override string Potencia { get { return _potencia; } set { _potencia = value; } }

        private string RetornarPotencia(string modelo)
        {
            switch (modelo.ToLower())
            {
                case "fusca":
                    return "60cv";
                case "parati":
                    return "90cv";
                default:
                    break;
            }

            return string.Empty;
        }

        private string RetornarConsumo(string modelo)
        {
            switch (modelo.ToLower())
            {
                case "fusca":
                    return "10Km/L";
                case "parati":
                    return "12Km/L";
                default:
                    break;
            }

            return string.Empty;
        }
    }
}
