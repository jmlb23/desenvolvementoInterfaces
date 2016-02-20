using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post.Modelo.entidades
{
    public class Covertura : IEntidade
    {
        private decimal _idCovertura;
        private decimal _idPoliza;
        private string _descripcion;
        //xa que os floats e doubles dan problemas na precision
        private decimal _prezo;

        public Covertura(decimal idCovertura,decimal idPoliza, string descripcion,decimal prezo)
        {
            _idCovertura = idCovertura;
            _idPoliza = idPoliza;
            _descripcion = descripcion;
            _prezo = prezo;
        }

        public Covertura()
        {
            
        }

        public decimal IdCovertura { get; set; }
        public decimal IdPoliza { get; set; }
        public string Descripcion{ get; set; }
        public decimal Prezo { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",_idCovertura,_idPoliza,_descripcion,_prezo);
        }

        public override bool Equals(object obj)
        {
            Covertura c = obj as Covertura;
            return this._idCovertura == c._idCovertura;
        }
    }
}
