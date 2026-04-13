using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void satınAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "")
                label6.Text = "0";
            else if (listBox1.Text == "Kadın Parfüm 1")
                label6.Text = "50";
            else if (listBox1.Text == "Kadın Parfüm 2")
                label6.Text = "100";
            else if (listBox1.Text == "Kadın Parfüm 3")
                label6.Text = "150";
            else if (listBox1.Text == "Kadın Parfüm 4")
                label6.Text = "200";
            else if (listBox1.Text == "Kadın Parfüm 5")
                label6.Text = "250";
            else if (listBox1.Text == "Kadın Parfüm 6")
                label6.Text = "300";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Text == "")
                label7.Text = "0";
            else if (listBox2.Text == "Erkek Parfüm 1")
                label7.Text = "50";
            else if (listBox2.Text == "Erkek Parfüm 2")
                label7.Text = "100";
            else if (listBox2.Text == "Erkek Parfüm 3")
                label7.Text = "150";
            else if (listBox2.Text == "Erkek Parfüm 4")
                label7.Text = "200";
            else if (listBox2.Text == "Erkek Parfüm 5")
                label7.Text = "250";
            else if (listBox2.Text == "Erkek Parfüm 6")
                label7.Text = "300";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam;
            listBox3.Items.Clear();

            if (listBox1.Text != "")
                listBox3.Items.Add("Kadın Parfüm" + listBox1.Text + " " + label6.Text); //label6 kadın parfümü kategorisindeki seçilen parfümün fiyatını yazdırır

            if (listBox2.Text != "")
                listBox3.Items.Add("Erkek Parfüm" + listBox2.Text + " " + label7.Text); //label7 erkek parfümü kategorisindeki seçilen parfümün fiyatını yazdırır

            toplam = int.Parse(label6.Text) + int.Parse(label7.Text);
            textBox1.Text = toplam.ToString(); //toplam fiyatı textboxta gösterir
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam, ogrenci, indirim, odenecekTutar;
            toplam = double.Parse(textBox1.Text);

            if (checkBox1.Checked)
                ogrenci = toplam / 20;
            else
                ogrenci = 0;
            if (toplam >= 100)
                indirim = toplam / 10;
            else
                indirim = 0;

            odenecekTutar = toplam - indirim - ogrenci;

            richTextBox1.Text = "";
            richTextBox1.Text += "Toplam Tutar = " + toplam + "\n";
            richTextBox1.Text += "İndirim Tutarı = " + indirim + "\n";
            richTextBox1.Text += "Ogrenci İndirimi = " + ogrenci + "\n";
            richTextBox1.Text += "_________";
            richTextBox1.Text += "Ödenecek Tutar = " + odenecekTutar + "\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz oluşturulmuştur."); 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
