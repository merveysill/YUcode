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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ana Sayfadasınız.");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ana Sayfadasınız.");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void şansZarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void magazinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void girişYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void bilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void yerÖnerisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
            this.Hide();
        }

        private void dizaynÖnerisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.Show();
            this.Hide();
        }
    }
}
