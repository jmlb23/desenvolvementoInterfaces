using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post.Modelo.entidades
{
    class Posue : IEntidade
    {
        private decimal _idPosue;
        private string _dni;
        private decimal _numeroVastidor;

        public Posue(decimal idPosue, string dni, decimal numeroVastidor)
        {
            _idPosue = idPosue;
            _dni = dni;
            _numeroVastidor = numeroVastidor;
        }
        
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        

        public decimal IdPosue
        {
            get { return _idPosue; }
            set { _idPosue = value; }
        }

        public decimal NumeroVastidor{ get; set; }
    }
}
