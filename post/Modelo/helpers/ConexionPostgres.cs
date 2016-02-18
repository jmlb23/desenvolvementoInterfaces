using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace post.Modelo.helpers
{
    class ConexionPostgres : ConexionAbstracta<NpgsqlConnection>
    {
        
        public override NpgsqlConnection open(string cadea)
        {
            NpgsqlConnection con = new NpgsqlConnection(cadea);
            con.Open();
            return con;
        }

        public override bool close(NpgsqlConnection cnn) {
            bool retorno = true;
            try
            {
                cnn.Close();
            }
            catch (Exception e)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
