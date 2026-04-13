using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Merve_Yesil
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection Baglanti = new SqlConnection();
        SqlCommand Komut = new SqlCommand();
        SqlCommand OkuKomut = new SqlCommand();
        // veritabani dan veri alıp datagridview içinde yazama kodu
        SqlDataAdapter sqlda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (Session["oturum"] != null)
                {
                    GridView1.Visible = true;
                }
                else
                {
                    GridView1.Visible = false;
                }
                Baglanti.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyVT;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=true";
                Baglanti.Open();
                if (!Page.IsPostBack)
                {
                    if (Session["statu"] != null)
                    {
                        if (Session["statu"].ToString().Trim() == "Admin")
                        {
                            veriGoster();
                        }
                        else
                        {
                            veriGosterNormal();
                        }
                    }
                }
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            OkuKomut.CommandText = "SELECT Email FROM myTB WHERE Email = '" + txtEmail.Text.ToString() + "' ";
            OkuKomut.Connection = Baglanti;
            SqlDataReader oku = OkuKomut.ExecuteReader();
            if (oku.HasRows)
            {
                while (oku.Read())
                {
                    Label1.Text = "Email onceden mevcut";
                }
            }
            else
            {
                Label1.Text = "kullanci eklenmiştir";
                Komut.CommandText = "INSERT INTO myTB (Adi, Soyadi, Email, DOB, Sehir, Sifre) VALUES ('" + txtAdi.Text.ToString() + "', '" + txtSoyadi.Text.ToString() + "', '" + txtEmail.Text.ToString() + "', '" + txtDOB.Text.ToString() + "','" + txtSehir.Text.ToString() + "', '" + txtSifre.Text.ToString() + "')";
                Komut.Connection = Baglanti;
                Komut.ExecuteNonQuery();
                veriGoster();
            }
            Baglanti.Close();

        }
        public void veriGoster()
        {
            ds = new DataSet();
            Komut.CommandText = "SELECT * FROM myTB";
            Komut.Connection = Baglanti;
            sqlda = new SqlDataAdapter(Komut);
            sqlda.Fill(ds);
            Komut.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Baglanti.Close();
        }

        public void veriGosterNormal()
        {
            ds = new DataSet();
            Komut.CommandText = "SELECT * FROM myTB WHERE Email =  '" + Session["Email"].ToString() + "' ";
            Komut.Connection = Baglanti;
            sqlda = new SqlDataAdapter(Komut);
            sqlda.Fill(ds);
            Komut.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Baglanti.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Komut.CommandText = "DELETE FROM myTB WHERE id = '" + txtID.Text.ToString() + "'";
            Komut.Connection = Baglanti;
            Komut.ExecuteNonQuery();
            veriGoster();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Komut.CommandText = "UPDATE myTB SET Adi= '" + txtAdi.Text.ToString() + "', SoyAdi ='" + txtSoyadi.Text.ToString() + "', Email ='" + txtEmail.Text.ToString() + "', DOB = '" + txtDOB.Text.ToString() + "', Sehir ='" + txtSehir.Text.ToString() + "', Sifre = '" + txtSifre.Text.ToString() + "' WHERE id = '" + txtID.Text.ToString() + "'";
            Komut.Connection = Baglanti;
            Komut.ExecuteNonQuery();
            veriGoster();
        }
    }
}
