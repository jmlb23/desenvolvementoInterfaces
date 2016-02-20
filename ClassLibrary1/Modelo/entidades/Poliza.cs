using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post.Modelo.entidades
{
    class Poliza : IEntidade
    {
        private decimal _idPoliza;
        private decimal _idCompanhia;
        private decimal _numeroVastidor;
        private DateTime _inicioPoliza;
        private DateTime _finPoliza;

        public Poliza( decimal idPoliza, decimal idCompanhia,decimal numeroVastidor,DateTime inicioPoliza, DateTime finPoliza)
        {
            _idPoliza = idPoliza;
            _idCompanhia = idCompanhia;
            _numeroVastidor = numeroVastidor;
            _inicioPoliza = inicioPoliza;
            _finPoliza = finPoliza;
        }
        public Poliza()
        {
            
        }
        public decimal IdPoliza{ get; set; }
        public decimal IdCompanhia { get; set; }
        public decimal NumeroVastidor { get; set; }
        public DateTime InicioPoliza { get; set; }
        public DateTime FinPoliza { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}",_idPoliza,_idCompanhia,_numeroVastidor,_inicioPoliza,_finPoliza);
        }

        public override bool Equals(object obj)
        {
            Poliza p = obj as Poliza;
            return this._finPoliza == p._finPoliza;
        }
    }
}
