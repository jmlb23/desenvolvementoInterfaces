using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace post.Modelo.entidades
{
    public enum Cor : byte {
        [Description("roxo")]
        ROXO,
        [Description("azul")]
        AZUL,
        [Description("amarelo")]
        AMARELO
       
    }
    class Vehiculo : IEntidade
    {
        private decimal _numero_vastidor;
        private string _modelo;
        private string _marca;
        private Cor _cor;


        

        public decimal NumeroVastidor { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public Cor Cor{ get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",_numero_vastidor,_modelo,_marca,_cor);
        }

        public override bool Equals(object obj)
        {
            Vehiculo v = obj as Vehiculo;
            return this._numero_vastidor == v._numero_vastidor;
        }
    }
}
