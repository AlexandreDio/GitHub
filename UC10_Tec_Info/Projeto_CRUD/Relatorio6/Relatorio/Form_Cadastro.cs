using Cadastro.DAO;
using Cadastro.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorio
{
    public partial class Form_Cadastro : Form
    {
        public string msgDeSucesso;
        private int? codigo; // int? = Nullable Int
        
        public Form_Cadastro(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
        }
        public Form_Cadastro(string titulo, int codigo) 
            : this(titulo)
        {
            this.codigo = codigo;
            var pessoa = BancoDados.Pessoas.Consultar(codigo);
            txt_Cidade.Text = pessoa.Cidade;
            txt_Endereço.Text = pessoa.Endereco;
            txt_Fone.Text = pessoa.Fone;
            txt_nome.Text = pessoa.Nome;
            txt_n.Text = pessoa.Numero;
            cbx_Estado.Text = pessoa.Estado;

        }


        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nome.Text))
                MessageBox.Show("Nome precisa ser informado.");
            else if (string.IsNullOrWhiteSpace(txt_n.Text))
                MessageBox.Show("Número precisa ser informado");
            else if (string.IsNullOrWhiteSpace(txt_Fone.Text))
                MessageBox.Show("Fone precisa ser informado.");
            else if (string.IsNullOrWhiteSpace(txt_Endereço.Text))
                MessageBox.Show("Endereço precisa ser informado");
            else if (string.IsNullOrWhiteSpace(txt_Cidade.Text))
                MessageBox.Show("Cidade precisa ser informado.");
            else if (string.IsNullOrWhiteSpace(cbx_Estado.Text))
                MessageBox.Show("UF precisa ser informado.");
            else
            {
                //Declara e instancia o objeto pessoa, do tipo Pessoa
                Pessoa pessoa = new Pessoa();
                //Atribui os valores dos campos do formulário às propriedades
                pessoa.Cidade = txt_Cidade.Text;
                pessoa.Nome = txt_nome.Text;
                pessoa.Estado = cbx_Estado.Text;
                pessoa.Endereco = txt_Endereço.Text;
                pessoa.Numero = txt_n.Text;
                pessoa.Fone = txt_Fone.Text;
                //Declara e instancio o objeto dao, do tipo PessoaDAO

                if (!codigo.HasValue)
                {
                    //Invoco o Método Inserir da DAO, para adicionar uma Pessoa
                    BancoDados.Pessoas.Inserir(pessoa);
                }
                else
                {
                    pessoa.Codigo = codigo.Value;
                    //Invoco o Método Alterar da DAO para alterar uma Pessoa
                    BancoDados.Pessoas.Alterar(pessoa);
                }
                

                msgDeSucesso = $"Voce efetuou o Cadastro: \nNome: {txt_nome.Text}" +
                    $"\nEndereço: {txt_Endereço.Text}\nN°: {txt_n.Text}\nFone: {txt_Fone.Text}" +
                    $"\nCidade: {txt_Cidade.Text}\nEstado: {cbx_Estado.Text}";

                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
