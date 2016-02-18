using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post.Modelo.entidades
{

    

    class Siniestro : IEntidade
    {
        private decimal _idSiniestro;
        private decimal _numeroBastidor;
        private Date _dataSinistro;
        private string _descripcionSuceso;

        public decimal IdSiniestro{ get; set; }
        public decimal NumeroBastidor{ get; set; }
        public Date DataSinistro { get; set; }
        public string DescripcionSuceso{ get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",_idSiniestro,_numeroBastidor,_dataSinistro,_descripcionSuceso);
        }

        public override bool Equals(object obj)
        {
            Siniestro s = obj as Siniestro;
            return this._idSiniestro == s._idSiniestro;
        }


    }
}
