
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;

namespace post.Modelo.entidades
{
    public class Tarefa : Entidade
    {
        string _id;
        string _descipcion;
        Prazo diasParaRematalo;
        List<Cliente> clientes;

        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Descipcion
        {
            get
            {
                return _descipcion;
            }

            set
            {
                _descipcion = value;
            }
        }

        public Prazo DiasParaRematalo
        {
            get
            {
                return diasParaRematalo;
            }

            set
            {
                diasParaRematalo = value;
            }
        }

        public List<Cliente> Clientes
        {
            get
            {
                return clientes;
            }

            set
            {
                clientes = value;
            }
        }

        public Tarefa(string _id, string _descipcion, Prazo diasParaRematalo, List<Cliente> clientes)
        {
            this._id = _id;
            this._descipcion = _descipcion;
            this.diasParaRematalo = diasParaRematalo;
            this.clientes = clientes;
        }

        public BsonDocument ToDocument() {
            return new BsonDocument("_id", _id).Add("descripcion", _descipcion).Add("prazo",diasParaRematalo.ToDocument()).Add("clientes",new BsonArray(clientes.Select(x => x.ToDocument())));
        }

        public override string ToString()
        {
            return string.Format(" {0} {1} {2} {3}",_id,_descipcion,diasParaRematalo.ToString(),clientes.ToString());
        }

    }

    public class Prazo : Entidade{
        DateTime _dataInicio;
        DateTime _dataFin;

        private Prazo(DateTime inicio, DateTime fin)
        {
            _dataInicio = inicio;
            _dataFin = fin;
        }

        public static Prazo makePrazo(DateTime inicio, DateTime fin)
        {
            validaData(inicio, fin);
            return new Prazo(inicio,fin);
        }
        public int DiasParaRematalo()
        {
            validaData();
            return _dataFin.DayOfYear - _dataInicio.DayOfYear;
        }
        private void validaData()
        {
            if (_dataInicio > _dataFin) throw new Exception("A data de inicio é maior que o fin");
        }

        private static void validaData(DateTime inicio, DateTime fin)
        {
            if (inicio > fin) throw new Exception("A data de inicio é maior que o fin");
        }
        public int ToIntDate()
        {
            return DiasParaRematalo();
        }

        public BsonDocument ToDocument()
        {
            return new BsonDocument("data_incio",_dataInicio).Add("data_fin",_dataFin).Add("dias_de_prazo",ToIntDate());
        }

        public override string ToString()
        {
            return string.Format(" {0} {1} {2}",_dataInicio.ToLongDateString(),_dataFin.ToLongDateString(),ToIntDate().ToString());
        }
    }

}