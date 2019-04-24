using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoTuiuiu
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            

            VerificaCartao();
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
                    PreencheCampos();
                }
                else
                {
                    DesabilitaControles();
                    lblMensagem.Text = "Insira o cartão na porta USB";
                }
            }
        }

        private void PreencheCampos()
        {
            txtNome.Text = "teste";
            txtConta.Text = "12345";
            txtSaldo.Text = "1.000,00";
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
    }
}
