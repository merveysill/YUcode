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
    public partial class Site1 : System.Web.UI.MasterPage
    {

        SqlConnection Baglanti = new SqlConnection();
        SqlCommand Komut = new SqlCommand();
        SqlDataAdapter sqlda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["oturum"] != null)
            {
                Label5.Visible = true;
                Label5.Text = Session["oturum"].ToString();
                Label3.Visible = false;
                Label4.Visible = false;
                txtEmail.Visible = false;
                txtPassword.Visible = false;
                Button2.Visible = false;
                Button3.Visible = false;
                Button4.Visible = true;
            }
            else
            {
                Label3.Visible = true;
                Label4.Visible = true;
                txtEmail.Visible = true;
                txtPassword.Visible = true;
                Button2.Visible = true;
                Button3.Visible = true;
                Button4.Visible = false;
                Session["oturum"] = null;
                Session["statu"] = null;
                Session["Email"] = null;
                Label5.Text = null;
                Label5.Visible = true;
            }

            Baglanti.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyVT;Integrated Security=True;Connect Timeout=30;";
            Baglanti.Open();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            Komut.CommandText = "SELECT * FROM myTB WHERE Email = '" + txtEmail.Text.ToString() + "' AND Sifre = '" + txtPassword.Text + "'";
            Komut.Connection = Baglanti;
            SqlDataReader oku = Komut.ExecuteReader();
            if (oku.HasRows)
            {
                while (oku.Read())
                {
                    //Label1.Text = "başarılı";
                    Session["oturum"] = oku.GetValue(1).ToString();
                    Session["statu"] = oku.GetValue(7).ToString();
                    Session["Email"] = oku.GetValue(3).ToString();
                    Label5.Visible = true;
                    Label5.Text = Session["oturum"].ToString();
                    Label3.Visible = false;
                    Label4.Visible = false;
                    txtEmail.Visible = false;
                    txtPassword.Visible = false;
                    Button2.Visible = false;
                    Button3.Visible = false;
                    Button4.Visible = true;
                    // Response.Redirect("AnaSayfa.aspx");
                }
            }
            else
            {
                Session["oturum"] = null;
                Session["statu"] = null;
                Session["Email"] = null;
                Label1.Text = "başarsız";
            }
            Baglanti.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Button1.Visible = false;
            Response.Redirect("GirisSayfa.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("KayitSayfa.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label3.Visible = true;
            Label4.Visible = true;
            txtEmail.Visible = true;
            txtPassword.Visible = true;
            Button2.Visible = true;
            Button3.Visible = true;
            Button4.Visible = false;
            Session["oturum"] = null;
            Session["statu"] = null;
            Session["Email"] = null;
            Label5.Text = null;
            Label5.Visible = true;
        }
    }
}