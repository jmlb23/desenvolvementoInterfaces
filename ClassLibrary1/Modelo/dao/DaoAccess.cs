using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using post.Modelo.entidades;

namespace post.Modelo.dao
{
    public class DaoAccess<E,T> : DaoAbstracto<E, OleDbConnection, T> where E : IEntidade
    {
        static DataSet tablas = new DataSet();
        OleDbDataAdapter adaptador;
        OleDbCommandBuilder builder;
        string tableName = typeof(E).Name.ToLower();
        public DaoAccess()
        {
            
            conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\proxectos\post\ClassLibrary1\Datos\seguros.accdb;Persist Security Info=True");

            conexion.Open();
            adaptador = new OleDbDataAdapter(string.Format("select * from {0}", tableName), conexion);

            builder = new OleDbCommandBuilder(adaptador);
            adaptador.Fill(tablas, tableName);
            tablas.Tables[tableName].PrimaryKey = new[] { tablas.Tables[tableName].Columns[0] };

        }

        public override void create(E entidade)
        {




            DataRow row = tablas.Tables[tableName].NewRow();

            int index = 0;
            //facelo con reflection non é moi elegante
            foreach (var pro in entidade.GetType().GetProperties())
            {
                row[index] = pro.GetValue(entidade);
                index++;
            }
            tablas.Tables[tableName].Rows.Add(row);

            adaptador.Update(tablas, tableName);
            tablas.AcceptChanges();
        }

        public override List<E> read()
        {
            List<E> listaElementos = new List<E>();
            foreach (DataRow rexistro in tablas.Tables[tableName].Rows)
            {
                listaElementos.Add((E)Activator.CreateInstance(typeof(E), rexistro.ItemArray));
            }
            return listaElementos;
        }

        public override E readOne(string campo, T valor)
        {
            DataRow row = tablas.Tables[tableName].Rows.Find(valor);
            if (row == null)
                throw new Exception("Non existe o rexitro");
            return (E)Activator.CreateInstance(typeof(E), row.ItemArray);
        }

        public override void remove(string campo, T valor)
        {
            tablas.Tables[tableName].Rows.Find(valor).Delete();
            adaptador.Update(tablas, tableName);
            tablas.AcceptChanges();
        }

        public override void update(E rexistroInfoAModificar, T clave)
        {
            DataRow aModificar = tablas.Tables[tableName].Rows.Find(clave);

            byte index = 0;
            foreach (var pro in typeof(E).GetProperties())
            {
                aModificar[index] = pro.GetValue(rexistroInfoAModificar);
                index++;
            }
            adaptador.Update(tablas, tableName);
            tablas.AcceptChanges();

        }

        //private string obtenCadeaConexion()
        //{
        //    return ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        //}
    }
}
