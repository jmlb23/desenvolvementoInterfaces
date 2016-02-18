using MongoDB.Bson;

namespace post.Modelo.entidades
{
    public class UbicacionCidadeProvinciaPais : Entidade
    {
        string _cidade;
        string _pais;
        string _provincia;

        public UbicacionCidadeProvinciaPais()
        {
                
        }
        public UbicacionCidadeProvinciaPais(params string[] cidadePaisProvincia)
        {
            _cidade = cidadePaisProvincia[0];
            _pais = cidadePaisProvincia[1];
            _provincia = cidadePaisProvincia[2];
        }

        public string Cidade
        {
            get
            {
                return _cidade;
            }

            set
            {
                _cidade = value;
            }
        }

        public string Pais
        {
            get
            {
                return _pais;
            }

            set
            {
                _pais = value;
            }
        }

        public string Provincia
        {
            get
            {
                return _provincia;
            }

            set
            {
                _provincia = value;
            }
        }

        public BsonDocument ToDocument()
        {
            return new BsonDocument("cidade", _cidade).Add("provincia", _provincia).Add("pais", _pais);
        }
        public override string ToString()
        {
            return string.Format(" {0} {1} {2}", _cidade, _provincia, _pais); ;
        }
    }
}