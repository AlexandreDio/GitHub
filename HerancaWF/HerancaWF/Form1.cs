using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ArrayList lista = new ArrayList(); 
            List<string> lista = new List<string>();
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {

                //if (d.IsReady == true && d.DriveType.ToString() == "Removable")
                //{
                //    MessageBox.Show($"Tipo de Drive: {d.DriveType} \nCartão inserido");
                //}
                //else
                //{
                //    MessageBox.Show($"Tipo de Drive: {d.DriveType} \nInsira seu cartão!");
                //}

                //foreach (var item in lista)
                //{
                //    listBox1.Items.Add(item);
                //}



                lista.Add($"Nome: {d.Name}");
                lista.Add($"Volume: {d.DriveType.ToString()}");
                if (d.IsReady == true)
                {
                    lista.Add(string.Format("Volume label: {0}", d.VolumeLabel));
                    lista.Add(string.Format("File system: {0}", d.DriveFormat));
                    lista.Add(string.Format("Available space to current user: {0, 15} bytes", d.AvailableFreeSpace));
                    lista.Add(string.Format("Total available space:{0, 15} bytes", d.TotalFreeSpace));
                    lista.Add(string.Format("Total size of drive: {0, 15} bytes ", d.TotalSize));
                }

                foreach (var item in lista)
                {
                    listBox1.Items.Add(item);
                }







                //Console.WriteLine("Drive {0}", d.Name);
                //Console.WriteLine("  Drive type: {0}", d.DriveType);
                //if (d.IsReady == true)
                //{
                //    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                //    Console.WriteLine("  File system: {0}", d.DriveFormat);
                //    Console.WriteLine(
                //        "  Available space to current user:{0, 15} bytes",
                //        d.AvailableFreeSpace);

                //    Console.WriteLine(
                //        "  Total available space:          {0, 15} bytes",
                //        d.TotalFreeSpace);

                //    Console.WriteLine(
                //        "  Total size of drive:            {0, 15} bytes ",
                //        d.TotalSize);
                //}
            }
        }
    }
}
