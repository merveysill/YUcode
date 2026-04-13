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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez!", "Uyarı penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning); //doldurmak zorunlu
            }

            else if (textBox1.Text != "merve" && textBox2.Text != "merve123")
            {
                MessageBox.Show("Kullanıcı adı vya şifre hatalı!", "Hata penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
