using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post.Modelo.entidades
{
    public class Companhia : IEntidade
    {

        private decimal _idCompanhia;
        private string _name;

       
        public Companhia() 
        {
           
        }

        public Companhia(decimal idCompanhia, string name)
        {
            _idCompanhia = idCompanhia;
            _name = name;
        }

        public decimal IdCompanhia 
        {
            get { return _idCompanhia; }
            set { _idCompanhia = value; }
        }

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}",_idCompanhia,_name);
        }
        public object[] toArray() {
            return new object[] { IdCompanhia,Name};
        }
    }
}
