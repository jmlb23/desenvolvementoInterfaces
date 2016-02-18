using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace post.Modelo.entidades
{
    public class Empregado : Entidade
    {
        string _dniPrimaryKey;
        string _nome;
        string _apelidos;
        List<Tarefa> _tarefas;

        public Empregado(string _dniPrimaryKey, string _nome, string _apelidos, List<Tarefa> _tarefas)
        {
            this._dniPrimaryKey = _dniPrimaryKey;
            this._nome = _nome;
            this._apelidos = _apelidos;
            this._tarefas = _tarefas;
        }

        public string DniPrimaryKey
        {
            get
            {
                return _dniPrimaryKey;
            }

            set
            {
                _dniPrimaryKey = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string Apelidos
        {
            get
            {
                return _apelidos;
            }

            set
            {
                _apelidos = value;
            }
        }

        public List<Tarefa> Tarefas
        {
            get
            {
                return _tarefas;
            }

            set
            {
                _tarefas = value;
            }
        }

        public BsonDocument ToDocument()
        {
            return new BsonDocument("_id",_dniPrimaryKey).Add("nome",_nome).Add("apelidos",_apelidos).Add("tarefa",new BsonArray(_tarefas.Select(x => x.ToDocument())));
        }

        public override string ToString()
        {
            return string.Format(" {0} {1} {2} {3}", _dniPrimaryKey,_nome,_apelidos,_tarefas.ToString());
        }
    }
}
