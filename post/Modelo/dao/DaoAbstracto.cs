using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using post.Modelo.helpers;
namespace post.Modelo.dao
{
    abstract class DaoAbstracto<E,C>
    {

        protected C conexion;
        public abstract bool create(string table);
        public abstract List<E> read(string table);
        public abstract E readOne(string table);
        public abstract bool update(E resgistro, string table);
        public abstract bool remove(E registro, string table);

    }
}
