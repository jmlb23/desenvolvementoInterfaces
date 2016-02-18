using MongoDB.Bson;

namespace post.Modelo.entidades
{
    public class Direcion : Entidade
    {

        string _ubicacionCalle;
        string _ubicacionNumero;

        public Direcion(string calle, string numero)
        {
            _ubicacionCalle = calle;
            _ubicacionNumero = numero;
        }

        public string Calle
        {
            get { return _ubicacionCalle; }
            set { _ubicacionCalle = value; }
        }

        public string Numero
        {
            get { return _ubicacionNumero; }
            set { _ubicacionNumero = value; }
        }

        public BsonDocument ToDocument()
        {
            return new BsonDocument("calle", _ubicacionCalle).Add("numero", _ubicacionNumero);
        }

        public override string ToString()
        {
            return string.Format(" {0} {0}", _ubicacionNumero, _ubicacionCalle);
        }
    }
}

