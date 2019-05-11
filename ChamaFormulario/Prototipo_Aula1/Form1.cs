using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Aula1
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnPrincipalConfirma_Click(object sender, EventArgs e)
        {

        }

        private void btnFrm1Confirma_Click(object sender, EventArgs e)
        {
            using (var form2 = new frm2())
            {
                form2.Entrada = txtFrm1Entrada.Text;
                form2.ShowDialog();
                txtFrm1Retorno.Text = form2.Retorno;
            }
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            txtFrm1Entrada.Focus();
            txtFrm1Entrada.Select();
            txtFrm1Retorno.ReadOnly = true;
            //Definir o botão confirma ao teclar Enter
            AcceptButton = btnFrm1Confirma;

            // Set the cancel button of the form to button2.
            //CancelButton = btnFrm1Fechar;
        }

        private void btnFrm1Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFrm1Confirma_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
