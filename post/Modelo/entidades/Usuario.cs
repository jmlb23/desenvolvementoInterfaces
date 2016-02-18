using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post.Modelo.entidades
{
    class Usuario
    {
        private int _id;
        private string nome;
        private string apelidos;

        public Usuario() {
            
        }

        public Usuario(string nome, string apelidos) {
            this.nome = nome;
            this.apelidos = apelidos;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Apelidos
        {
            get { return apelidos; }
            set { apelidos = value; }
        }

        public override string ToString()
        {
            return string.Format("%s %s",nome,apelidos);
        }

        public override bool Equals(object obj)
        {
            return nome.Equals(((Usuario)obj).nome) && apelidos.Equals(((Usuario)obj).apelidos);
        }
    }
}
