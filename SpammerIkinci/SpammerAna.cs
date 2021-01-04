using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SpammerIkinci
{
    public partial class SpammerAna : Form
    {
        public SpammerAna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                MessageBox.Show("Spam zaten çalışıyor.\nTekrar başlatmak için şu anki işlemi durdurun.","Hata!");
            }
            else
            {
                MessageBox.Show("Spam 3 saniye içinde başlayacak.\n3 Saniye içinde spamlanacak yeri seçiniz.", "Bilgi");
                Thread.Sleep(3000);
                this.timer1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                MessageBox.Show("Spam zaten devre dışı.\nSpamı durdurmak için öncelikle spamı başlatın.","Hata!");
            }
            else
            {
                this.timer1.Stop();
                Thread.Sleep(500);
                MessageBox.Show("Spam başarıyla durduruldu.", "Bilgi");
            }
        }

        private void SpammerAna_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/ziksthemw");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ziksthemw");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ziksthemw");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomsayi = random.Next(900);
            if (checkBox1.Checked)
            {
                SendKeys.Send(randomsayi.ToString() + richTextBox1.Text + "{enter}");
            }
            else
            {
                SendKeys.Send(richTextBox1.Text + "{enter}");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
