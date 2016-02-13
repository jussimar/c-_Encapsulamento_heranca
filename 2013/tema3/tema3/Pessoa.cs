using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema3
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;
        private int idade;

        /// <summary>
        /// mostra o nome completo da pessoa
        /// </summary>
        public void mostrarNomeCompleto()
        {
            Console.WriteLine("Nome Completo : {0} {1}", nome, sobrenome);
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public int getIdade()
        {
            return this.idade;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
    }
}
