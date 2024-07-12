using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Form3 : Form
    {
        private Ogrenci ogrenci;

        public Form3(Ogrenci ogrenci)
        {
            InitializeComponent();
            this.ogrenci = ogrenci;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Öğrencinin ismi: " + ogrenci.Ad;
            label2.Text = "Öğrencinin soyadı: " + ogrenci.Soyad;
            label3.Text = "Yaşı: " + ogrenci.Yas;
            label4.Text = "Cinsiyeti: " + ogrenci.Cinsiyet;
            label5.Text = "Öğrenci No: " + ogrenci.OgrenciNo;
            //label6.Text = "Dersi: " + ogrenci.Ders;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
