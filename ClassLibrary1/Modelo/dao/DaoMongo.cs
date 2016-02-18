using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using post.Modelo.entidades;
using System.Web.Script.Serialization;


namespace post.Modelo.dao
{
    public class DaoMongo<E> : DaoAbstracto<E,MongoClient,BsonDocument>
    {
        IMongoDatabase baseDatos;
        IMongoCollection<BsonDocument> collecion;

        public DaoMongo() 
        {
            conexion = new MongoClient();
            baseDatos = conexion.GetDatabase("Empresa");
            collecion = baseDatos.GetCollection<BsonDocument>("Empresa_table");
        }
        public override void create(string table,E entidade)
        {
            BsonDocument doc = ((Entidade)entidade).ToDocument();
            collecion.InsertOne(doc);
        }

        public override List<E> read(string table)
        {
            return new JavaScriptSerializer().Deserialize<List<E>>( collecion.Find(new BsonDocument()).ToJson());
        }

        public override E readOne(string table,BsonDocument criteria)
        {
            return new JavaScriptSerializer().Deserialize<E>(collecion.Find(criteria).ToJson());
        }

        public override void update(string table,E resgistro,BsonDocument criteria)
        {
            throw new NotImplementedException();
        }

        public override void remove(string table,E registro,BsonDocument criteria)
        {
            throw new NotImplementedException();
        }
    }
}
