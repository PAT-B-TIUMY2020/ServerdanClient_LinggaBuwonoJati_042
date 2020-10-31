using ServiceMtk_P1_20180140042;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_LinggaBuwonoJati_20180140042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Open();
                //Console.WriteLine("Server is Ready!!!");
                //Console.ReadLine();
                label1.Text = "Server ON!!!";
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Server OFF";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Klik ON untuk mematikan server";
        }
    }
}
