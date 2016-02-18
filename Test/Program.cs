using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using post.Modelo.dao;
using post.Modelo.entidades;
using System.Web.Script.Serialization;
namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Companhia c = new Companhia();

            c.IdCompanhia = 48;
            c.Name = "merda2";
           

            DaoSqlServer<Companhia> dao = new DaoSqlServer<Companhia>();
            //dao.create(c);
            dao.read().ForEach(Console.WriteLine);
            Console.Read();

        }
    }
}
