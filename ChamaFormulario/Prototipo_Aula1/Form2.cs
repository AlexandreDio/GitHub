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
    public partial class frm2 : Form
    {
        public string Entrada { get; set; }
        public string Retorno { get; set; }

        public frm2()
        {
            InitializeComponent();

        }

        private void frm2_Load(object sender, EventArgs e)
        {
            txtFrm2Retorno.Focus();
            txtFrm2Retorno.Select();
            txtFrm2Entrada.Text = Entrada;
            txtFrm2Entrada.ReadOnly = true;
            
            //Definir o botão Confirma ao pressionar Enter
            AcceptButton = btnFrm2Confirma;
        }

        private void btnFrm2Confirma_Click(object sender, EventArgs e)
        {
            using (var form1 = new frm1())
            {
                this.Retorno = txtFrm2Retorno.Text;
                this.Close();
            }
        }
    }
}
