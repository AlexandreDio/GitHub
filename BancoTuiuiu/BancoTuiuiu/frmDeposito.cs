using System;
using System.Windows.Forms;
using System.Globalization;

namespace BancoTuiuiu
{
    public partial class frmDeposito : Form
    {
        private decimal saldo;
        frmPrincipal principal = new frmPrincipal();

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        

        public frmDeposito()
        {
            InitializeComponent();

            txtDepositoValor.Text = 0.ToString("C2",CultureInfo.CurrentCulture);
            principal.AplicarEventos(txtDepositoSaldo);
            principal.AplicarEventos(txtDepositoValor);
        }

        private void btnDepositoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSaqueValor_Click(object sender, EventArgs e)
        {

        }

        private void btnDepositoConfirmar_Click(object sender, EventArgs e)
        {
            principal.TirarMascara(txtDepositoSaldo,e);
            principal.TirarMascara(txtDepositoValor,e);
            this.saldo = decimal.Parse(txtDepositoSaldo.Text) + decimal.Parse(txtDepositoValor.Text);
            this.Close();
        }

        private void frmDeposito_Load(object sender, EventArgs e)
        {
            txtDepositoSaldo.ReadOnly = true;
            txtDepositoSaldo.Text = this.saldo.ToString("C2",CultureInfo.CurrentCulture);
        }

        private void txtDepositoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
