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
    public partial class Form_Pessoas : Form
    {
        BindingSource binding;
        public Form_Pessoas()
        {
            InitializeComponent();
            binding = new BindingSource();//Instancializa no construtor
        }

        private void btn_NovaPessoa_Click(object sender, EventArgs e)
        {
            Form_Cadastro cadastro = new Form_Cadastro("MINHA TELA DE CADASTRO DE PESSOA");
            cadastro.ShowDialog();

            AtualizaGrid();

            MessageBox.Show(cadastro.msgDeSucesso,"Sucesso");
        }
        private void AtualizaGrid(object data=null)
        {
            //
            binding.DataSource = data??BancoDados.Pessoas.Pesquisar();
            binding.ResetBindings(true);
            dgvPessoas.DataSource = binding;            
        }
        private void Form_Pessoas_Load(object sender, EventArgs e)
        {
            dgvPessoas.AutoGenerateColumns = false;

            AtualizaGrid();
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizaGrid(BancoDados.
                Pessoas.Pesquisar(txtNomePesquisa.Text));
        }

        private void dgvPessoas_CellDoubleClick(object sender,
            DataGridViewCellEventArgs e)
        {
            //e.RowIndex = Posição da Linha clicada
            //(CAST)
            var pessoa = (Pessoa)dgvPessoas.Rows[e.RowIndex].DataBoundItem;

            Form_Cadastro cadastro = 
                new Form_Cadastro("MINHA TELA DE ALTERAÇÃO DE PESSOA", 
                pessoa.Codigo);
            cadastro.ShowDialog();

            AtualizaGrid();

        }
    }
}
