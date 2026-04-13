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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            this.Hide();
        }
    }
}
