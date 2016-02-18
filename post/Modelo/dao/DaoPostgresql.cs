using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using post.Modelo.entidades;
using post.Modelo.helpers;
namespace post.Modelo.dao
{
    class DaoPostgresql<T> : DaoAbstracto<T,ConexionPostgres>
    {
        public DaoPostgresql()
        {
            conexion = new ConexionPostgres();
            
        }
        public override bool create(string table)
        {
            
            throw new NotImplementedException();
        }

        public override List<T> read(string table)
        {
            throw new NotImplementedException();
        }

        public override T readOne(string table)
        {
            throw new NotImplementedException();
        }

        public override bool remove(T registro, string table)
        {
            throw new NotImplementedException();
        }

        public override bool update(T resgistro, string table)
        {
            throw new NotImplementedException();
        }
    }
}
