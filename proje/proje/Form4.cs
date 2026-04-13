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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int zar1;
            zar1 = random.Next(0, 6);
            pictureBox1.Image = ımageList1.Images[zar1];
            timer1.Start();
            button1.Enabled = false;
        }
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int zar1;
            Random rnd = new Random();
            zar1 = rnd.Next(0, 6);
            pictureBox1.Image = ımageList1.Images[zar1];
            sayac++;
            if (sayac == 30)
            {
                timer1.Stop();
                sayac = 0;
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

