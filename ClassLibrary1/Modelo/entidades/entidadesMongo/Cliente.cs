using System;
using MongoDB.Bson;

namespace post.Modelo.entidades
{
    public class Cliente : Entidade
    {
        string _dniPrimary;
        Direcion _direcion;
        UbicacionCidadeProvinciaPais _ubicacion;

        public string DniPrimary
        {
            get
            {
                return _dniPrimary;
            }

            set
            {
                _dniPrimary = value;
            }
        }

        public Direcion Direcion
        {
            get
            {
                return _direcion;
            }

            set
            {
                _direcion = value;
            }
        }

        public UbicacionCidadeProvinciaPais Ubicacion
        {
            get
            {
                return _ubicacion;
            }

            set
            {
                _ubicacion = value;
            }
        }

        public Cliente(string _dniPrimary, Direcion _direcion, UbicacionCidadeProvinciaPais _ubicacion)
        {
            this._dniPrimary = _dniPrimary;
            this._direcion = _direcion;
            this._ubicacion = _ubicacion;
        }

        public BsonDocument ToDocument()
        {
            return new BsonDocument("dni",_dniPrimary).Add("direcion",_direcion.ToDocument()).Add("ubicacion",_ubicacion.ToDocument());
        }

        public override string ToString()
        {
            return string.Format(" {0} {1} {2} ", _dniPrimary,_direcion.ToString().Trim(),_ubicacion.ToString().Trim()); ;
        }
    }
}