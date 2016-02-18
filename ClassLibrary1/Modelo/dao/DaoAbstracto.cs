using System.Collections.Generic;

namespace post.Modelo.dao
{
    public abstract class DaoAbstracto<E, C, T>
    {

        protected C conexion;
        public abstract void create(E entidade);
        public abstract List<E> read();
        public abstract E readOne( string campo,uint valor);
        public abstract void update(E resgistro, string campo, uint valor);
        public abstract void remove( E resgistro, string campo, uint valor);

    }

}
