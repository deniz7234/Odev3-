using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sehir, ad, soyad, cinsiyet, yas;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            cinsiyet = textBox3.Text;
            yas = textBox4.Text;
            sehir = textBox5.Text;
            label15.Text = ad;
            label14.Text = soyad;
            label13.Text = cinsiyet;
            label12.Text = yas;
            label11.Text = sehir;
        }
    }
}
