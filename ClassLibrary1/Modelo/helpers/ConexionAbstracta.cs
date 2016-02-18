using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post.Modelo.helpers
{
    public abstract class ConexionAbstracta<T>
    {
        public abstract T open();
        public abstract void close(T conn);
    }
}
