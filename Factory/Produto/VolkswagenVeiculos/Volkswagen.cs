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

        public Volkswagen(string consumo, string potencia)
        {
            _modelo = "Fusca";
            _consumo = consumo;
            _potencia = potencia;
        }

        public Volkswagen(string modelo)
        {
            _modelo = modelo;
        }

        public override string Modelo { get { return _modelo; } }
        public override string Consumo { get { return _consumo; } set { _consumo = value; } }
        public override string Potencia { get { return _potencia; } set { _potencia = value; } }
    }
}
