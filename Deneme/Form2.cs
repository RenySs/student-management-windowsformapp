using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Form2 : Form

    {
        public Form2()
        {
            InitializeComponent();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamayı kapatırsın heee","uygulamayı kapatıyorsun",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Niye Tıkladın ki ?!", "NİYE??", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tamam bida yapmıcam", "Şaka Sadece", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void checkedListBox1_Click(object sender, EventArgs e)
        {
         
           
        }
        private void checkedListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
          
        }

        public void button1_Click(object sender, EventArgs e)
        {

            string ad = textBox1.Text.ToUpper();
            string soyad = textBox3.Text.ToUpper();
            string noT = textBox2.Text;

            int no = int.Parse(noT);
            int yas = (int)numericUpDown1.Value;
            string cin = checkedListBox1.CheckedItems[0].ToString();



            string ders = textBox4.Text.ToUpper();

          Ogrenci ogrenci = new Ogrenci(); 
            //BirinciSinif ogrenci = new BirinciSinif();
            ogrenci.Ad = ad;
            ogrenci.Soyad = soyad;
            ogrenci.Cinsiyet = cin;
            ogrenci.Yas = yas;
            ogrenci.OgrenciNo = no;
            //ogrenci.Ders = ders;
            MessageBox.Show("Öğrencinin isimi: "+ogrenci.Ad + " Öğrencinin soyadı: " +ogrenci.Soyad+ " Yaşı: "+ogrenci.Yas
                +" Cinsiyeti: "+ogrenci.Cinsiyet+" Ogreci no: "+ogrenci.OgrenciNo/*+" Dersi: "+ogrenci.Ders*/,"bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            Form3 form3 = new Form3(ogrenci);
            form3.Show();
            this.Hide();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Diğer tüm seçili öğelerin seçimini kaldır
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
        }

       
    }
}
