using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace post.Modelo.helpers
{
    public class ConexionSqlServer : ConexionAbstracta<SqlConnection>
    {
        private SqlConnection conexion;
        public ConexionSqlServer(string cadeaConexion) {
            conexion = new SqlConnection(cadeaConexion);
        }
        public override SqlConnection open()
        {
            
            return conexion;
        }

        public override void close(SqlConnection conn)
        {
            
            conn.Close();
        }
    }
}
