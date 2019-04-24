using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BancoTuiuiu
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            AplicarEventos(txtSaldo);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            VerificaCartao();
            RetornarMascara(txtSaldo,e);
        }

        private void VerificaCartao()
        {
            List<string> lista = new List<string>();
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true && d.DriveType.ToString() == "Removable")
                {
                    HabilitaControles();
                    PreencheCampos(d.VolumeLabel,d.TotalSize,d.AvailableFreeSpace);
                }
                else
                {
                    //DesabilitaControles();
                    lblMensagem.Text = "Insira o cartão na porta USB";
                }
            }
        }

        private void PreencheCampos(string nome,long conta,decimal saldo)
        {
            txtNome.Text = nome;
            txtConta.Text = conta.ToString().Substring(0,5);
            //txtSaldo.Text = String.Format(CultureInfo.GetCultureInfo("pt-BR"),
            //                     "{0:N}", saldo);
            //txtSaldo.Text = saldo.ToString("C2",CultureInfo.CurrentCulture); 
            txtSaldo.Text = saldo.ToString();
            SomenteLeitura();
        }

        private void SomenteLeitura()
        {
            txtNome.ReadOnly = true;
            txtConta.ReadOnly = true;
            txtSaldo.ReadOnly = true;
        }

        private void LeituraGravacao()
        {
            txtNome.ReadOnly = false;
            txtConta.ReadOnly = false;
            txtSaldo.ReadOnly = false;
        }

        private void HabilitaControles()
        {
            txtNome.Enabled = true;
            txtConta.Enabled = true;
            txtSaldo.Enabled = true;
            btnDepositio.Enabled = true;
            btnSaque.Enabled = true;
            pnlMensagem.Visible = false;
            lblMensagem.Visible = false;
        }

        private void DesabilitaControles()
        {
            txtNome.Enabled = false;
            txtConta.Enabled = false;
            txtSaldo.Enabled = false;
            btnDepositio.Enabled = false;
            btnSaque.Enabled = false;
            pnlMensagem.Visible = true;
            lblMensagem.Visible = true;
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            //var frm = new frmSaque(txtSaldo.Text);
            //frm.ShowDialog();
            //this.Visible = true;

            using (var frmSaque = new frmSaque())
            {
                TirarMascara(txtSaldo,e);
                frmSaque.Saldo = decimal.Parse(txtSaldo.Text);
                frmSaque.ShowDialog();
                txtSaldo.Text = frmSaque.Saldo.ToString();
                RetornarMascara(txtSaldo, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDepositio_Click(object sender, EventArgs e)
        {
            using (var frmDeposito = new frmDeposito())
            {
                TirarMascara(txtSaldo, e);
                frmDeposito.Saldo = decimal.Parse(txtSaldo.Text);
                frmDeposito.ShowDialog();
                txtSaldo.Text = frmDeposito.Saldo.ToString();
                RetornarMascara(txtSaldo, e);
            }
        }

        public void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        public void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = decimal.Parse(txt.Text).ToString("C2",CultureInfo.CurrentCulture);
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        public void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }

        private void gbOpcoes_Enter(object sender, EventArgs e)
        {

        }

        private void txtSaldo_Enter(object sender, EventArgs e)
        {

        }

        private void txtSaldo_Leave(object sender, EventArgs e)
        {

        }

        private void txtConta_Enter(object sender, EventArgs e)
        {
            //AplicarEventos(txtSaldo);
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_Enter(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
