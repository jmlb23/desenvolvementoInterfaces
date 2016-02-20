using System.Collections.Generic;

namespace post.Modelo.dao
{
    public abstract class DaoAbstracto<E, C, T>
    {

        protected C conexion;
        public abstract void create(E entidade);
        public abstract List<E> read();
        public abstract E readOne(string campo,T valor);
        public abstract void update(E campo, T valor);
        public abstract void remove(string campo, T valor);

    }

}
