using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.MODEL
{
    public class Pessoa
    {
        //Gerar Getters and Setters automaticamente: CTRL + K + X ou propfull

        #region MembrosDaClasse
        private int codigo;
        private string nome;
        private string endereco;
        private string numero;
        private string fone;
        private string cidade;
        private string estado;
        #endregion
        #region Construtor padrão
        public Pessoa()
        {
        }
        #endregion
        #region Construtor com todos os membros
        // Gerando o Construtor selecionando os atributos da classe acima e com o teclado CTRL+.
        public Pessoa(string nome, string endereco, string numero, string fone, string cidade, string estado)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.numero = numero;
            this.fone = fone;
            this.cidade = cidade;
            this.estado = estado;
        }
        #endregion
        #region GettersAndSetters
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Fone
        {
            get { return fone; }
            set { fone = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        #endregion

    }

}
