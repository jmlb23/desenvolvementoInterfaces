using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post.Modelo.entidades
{
    public class Conductor : IEntidade
    {
        private string _dni;
        private string _nome;
        private string _apelidos;
        private bool _eConductor;

        
        public Conductor()
        {
            
        }

        public bool EConductor
        {
            get { return _eConductor; }
            set { _eConductor = value; }
        }
        
        public string Apelidos
        {
            get { return _apelidos; }
            set { _apelidos = value; }
        }
        
        public string Nome
        {
            get;
            set;
        }
        
        public string Dni
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",_dni,_nome,_apelidos,_eConductor);
        }

        public override bool Equals(object obj)
        {
            Conductor c = obj as Conductor;

            return _dni.Equals(c._dni);
        }
    }
}
