using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Location.Y.ToString();
            label2.Text = label2.Location.Y.ToString();
            label3.Text = label3.Location.Y.ToString();
            label4.Text = label4.Location.Y.ToString();
            label5.Text = label5.Location.Y.ToString();
            label6.Text = label6.Location.Y.ToString();
            label7.Text = label7.Location.Y.ToString();
            label8.Text = label8.Location.X.ToString();
            label9.Text = label9.Location.X.ToString();
            label10.Text = label10.Location.X.ToString();
            label11.Text = label11.Location.X.ToString();
            label12.Text = label12.Location.X.ToString();
            label13.Text = label13.Location.X.ToString();
            label14.Text = label14.Location.X.ToString();
        }
    }
}
