using Cadastro.DAO;
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
        public Form_Pessoas()
        {
            InitializeComponent();
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
            
            bsPessoas.DataSource = data??BancoDados.Pessoas.Pesquisar();
            bsPessoas.ResetBindings(true);
            
            
        }

        private void Form_Pessoas_Load(object sender, EventArgs e)
        {
            dgvPessoas.AutoGenerateColumns = false;
            dgvPessoas.DataSource = bsPessoas;
            AtualizaGrid();
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizaGrid(BancoDados.
                Pessoas.Pesquisar(txtNomePesquisa.Text));
        }
    }
}
