using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListaDrivers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Red;

            //Lista
            List<string> lista = new List<string>();

            //Provê acesso a todos os drivers conectados na máquina
            DriveInfo[] alldrives = DriveInfo.GetDrives();

            foreach (DriveInfo item in alldrives)
            {
                lista.Add($"Nome: {item.Name}");
                lista.Add($"Volume: {item.DriveType.ToString()}");

                if (item.IsReady == true)
                {
                    lista.Add($"Volume label: {item.VolumeLabel}");
                    lista.Add($"Sistema de arquivos: {item.DriveFormat}");
                    lista.Add($"Espaço em disco para o usuário atual: {item.AvailableFreeSpace}");
                    lista.Add($"Total espaço disponível: {item.TotalFreeSpace}");
                    lista.Add($"Tamanho toal do drive: {item.TotalSize}");
                }
            }

            foreach (var ls in lista)
            {
                listBox1.Items.Add(ls);
            }
        }
    }
}
