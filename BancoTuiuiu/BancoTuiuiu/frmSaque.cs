using System;
using System.Windows.Forms;
using System.Globalization;

namespace BancoTuiuiu
{
    public partial class frmSaque : Form
    {
        private decimal saldo;
        frmPrincipal principal = new frmPrincipal();

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public frmSaque()
        {
            InitializeComponent();
            //txtSaqueSaldo.Text = saldo;

            txtSaqueValor.Text = 0.ToString("C2");

            principal.AplicarEventos(txtSaqueSaldo);
            principal.AplicarEventos(txtSaqueValor);
        }

        private void btnSaqueConfirmar_Click(object sender, EventArgs e)
        {
            principal.TirarMascara(txtSaqueValor, e);
            principal.TirarMascara(txtSaqueSaldo, e);
            this.saldo = decimal.Parse(txtSaqueSaldo.Text) - decimal.Parse(txtSaqueValor.Text);
            this.Close();
        }

        private void btnSaqueCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSaque_Load(object sender, EventArgs e)
        {
            txtSaqueSaldo.ReadOnly = true;
            txtSaqueSaldo.Text = this.saldo.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void txtSaqueValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtSaqueValor_Enter(object sender, EventArgs e)
        {

        }

        private void frmSaque_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
