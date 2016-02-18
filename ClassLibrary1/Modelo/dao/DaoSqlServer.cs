using System;
using System.Collections.Generic;
using post.Modelo.helpers;
using post.Modelo.entidades;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;

namespace post.Modelo.dao
{

    public class DaoSqlServer<E> : DaoAbstracto<E, SqlConnection, string> where E : IEntidade, new()
    {
        static DataSet tablas = new DataSet();
        SqlDataAdapter adaptador;
        SqlCommandBuilder builder;
        string tableName = typeof(E).Name.ToLower();
        public DaoSqlServer() 
        {
            
            conexion = new SqlConnection($"Server=tcp:porbas.database.windows.net,1433;Database=seguros_2016-02-16T23-07Z;User ID=jesus@porbas;Password={"and123..one456,,"};Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            conexion.Open();
            adaptador = new SqlDataAdapter($"select * from {tableName}" , conexion);
            
            builder = new SqlCommandBuilder(adaptador);
            adaptador.Fill(tablas,tableName);
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
            
            adaptador.Update(tablas,tableName);
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

        public override E readOne(string campo, uint valor)
        {
            DataRow row = tablas.Tables[tableName].Rows.Find(valor);
            if (row == null)
                throw new Exception("Non existe o rexitro");
            return (E)Activator.CreateInstance(typeof(E),row.ItemArray);
        }

        public override void remove(E resgistro, string campo, uint valor)
        {
            throw new NotImplementedException();
        }

        public override void update(E resgistro, string campo, uint valor)
        {
            throw new NotImplementedException();
        }

        private string obtenCadeaConexion() 
        {
            return ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        }
    }
}
