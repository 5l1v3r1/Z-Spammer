using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpammerIkinci;

namespace ZikSpammer2
{
    public partial class LisansGirisi : Form
    {
        public LisansGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpammerIkinci.SpammerAna prj2 = new SpammerIkinci.SpammerAna();
            string Sifre = "CodedByZiksthemW";
            if (textBox1.Text == Sifre)
            {
                MessageBox.Show("Lisans Anahtarınız Geçerli!", "Bilgi");
                Console.Write("Kullanıcı başarıyla uygulamaya giriş yaptı.");
                this.Hide();
                prj2.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Hatalı lisans anahtarı.\nGithub sayfamızdan lisans anahtarını alabilirsiniz.\nLisans kodu büyük küçük harf duyarlı.", "Hata!");
                Console.WriteLine("Kullanıcı hatalı lisans anahtarı girdi.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
