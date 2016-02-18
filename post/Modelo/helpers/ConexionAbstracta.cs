using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post.Modelo.helpers
{
    abstract class ConexionAbstracta<T>
    {
        public abstract T open(string cadea);
        public abstract bool close(T conn);
    }
}
