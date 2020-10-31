using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_LinggaBuwonoJati_20180140042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.MatematikaClient obj = new
             ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Tambah(1, 2);
            Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(3, 2);
            Console.WriteLine("3 - 2 = " + hasilKurang);
            double hasilKali = obj.Kali(2, 2);
            Console.WriteLine("2 x 2 = " + hasilKali);
            double hasilBagi = obj.Bagi(2, 2);
            Console.WriteLine("2 / 2 = " + hasilBagi);

            ServiceReference1.Koordinat a = new
           ServiceReference1.Koordinat();
            ServiceReference1.Koordinat b = new
           ServiceReference1.Koordinat();
            a.X = 7;
            a.Y = 8;

            b.X = 5;
            b.Y = 6;
            double selisihX = a.X - b.X;
            double selisihY = a.Y - b.Y;
            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) +
            Math.Pow(selisihY, 2));
            //Console.WriteLine("Hasil Koordinat " + jarak);
            //Console.ReadLine();
            label1.Text = "1 + 2 = " + hasilTambah + "Hasil Koordinat" + jarak;
            label2.Text = "3 - 2 = " + hasilKurang + "Hasil Koordinat" + jarak;
            label3.Text = "2 x 2 = " + hasilKali + "Hasil Koordinat" + jarak;
            label4.Text = "2 / 2 = " + hasilBagi + "Hasil Koordinat" + jarak;
        }
    }
}
