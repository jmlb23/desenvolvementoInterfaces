using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
namespace post.Modelo.entidades
{
    public class Departamento : Entidade
    {
        string _nomePrimaryKey;
        string _descripcionFuncions;
        UbicacionCidadeProvinciaPais _CidadeProvinciasPais;
        Direcion _direcionCalleNumero;
        List<Empregado> _empregados;
        public Departamento()
        {
        }
        public Departamento(string _nomePrimaryKey, string _descripcionFuncions, UbicacionCidadeProvinciaPais _CidadeProvinciasPais, Direcion _direcionCalleNumero, List<Empregado> _empregados)
        {
            this._nomePrimaryKey = _nomePrimaryKey;
            this._descripcionFuncions = _descripcionFuncions;
            this._CidadeProvinciasPais = _CidadeProvinciasPais;
            this._direcionCalleNumero = _direcionCalleNumero;
            this._empregados = _empregados;
        }

        public string NomePrimaryKey
        {
            get
            {
                return _nomePrimaryKey;
            }

            set
            {
                _nomePrimaryKey = value;
            }
        }

        public string DescripcionFuncions
        {
            get
            {
                return _descripcionFuncions;
            }

            set
            {
                _descripcionFuncions = value;
            }
        }

        public Direcion DirecionCalleNumero
        {
            get
            {
                return _direcionCalleNumero;
            }

            set
            {
                _direcionCalleNumero = value;
            }
        }

        public List<Empregado> Empregados
        {
            get
            {
                return _empregados;
            }

            set
            {
                _empregados = value;
            }
        }

        public UbicacionCidadeProvinciaPais CidadeProvinciasPais
        {
            get
            {
                return _CidadeProvinciasPais;
            }

            set
            {
                _CidadeProvinciasPais = value;
            }
        }

        public BsonDocument ToDocument()
        {
            return new BsonDocument("_id", _nomePrimaryKey)
                                                           .Add("descripcion", _descripcionFuncions)
                                                           .Add("provincia", _CidadeProvinciasPais.ToDocument())
                                                           .Add("direcion", _direcionCalleNumero.ToDocument())
                                                           .Add("empregados", BsonArray.Create(_empregados.Select(x=>x.ToDocument())));
        }

        public override string ToString()
        {
            return string.Format(" {0} {1} {2} {3} ", _nomePrimaryKey,_descripcionFuncions,_direcionCalleNumero.ToString(),_CidadeProvinciasPais.ToString());
        }
    }


}
    