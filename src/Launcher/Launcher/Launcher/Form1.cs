using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;



namespace Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            



        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            //this.ShowDialog.Hide();
            // System.Diagnostics.Process.Start("notepad.exe", "");
            Process cmd = new Process();
            cmd.StartInfo.FileName = "node";
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.StartInfo.Arguments = "index.dfs";
            cmd.Start();
            bool interruptor = true;
            string temporal = "BOT ACTIVO";
            label1.Text = temporal;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "taskkill";
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.StartInfo.Arguments = "/f /im node.exe";
            cmd.Start();

            if(label1.Text=="BOT ACTIVO")
            {
                label1.Text="BOT INACTIVO";
            }

            





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
