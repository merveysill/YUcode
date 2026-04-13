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
    public partial class WebForm8 : System.Web.UI.Page
    {
        SqlConnection Baglanti = new SqlConnection();
        SqlCommand Komut = new SqlCommand();
        SqlDataAdapter sqlda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            Baglanti.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyVT;Integrated Security=True;Connect Timeout=30;";
            Baglanti.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            Komut.CommandText = "SELECT Id, Sehir, Email FROM myTB WHERE Email = '" + txtEmail.Text.ToString() + "' AND Sifre = '" + txtPassword.Text + "'";
            Komut.Connection = Baglanti;
            SqlDataReader oku = Komut.ExecuteReader();
            if (oku.HasRows)
            {
                while (oku.Read())
                {
                    Label6.Text = "başarılı";
                    Session["oturum"] = oku.GetValue(1).ToString();
                    Session["statu"] = oku.GetValue(2).ToString();
                    Session["Email"] = oku.GetValue(3).ToString();   
                }
            }
            else
            {
                Session["oturum"] = null;
                Session["statu"] = null;
                Session["Email"] = null;
                Label6.Text = "başarsız";
            }
            Baglanti.Close();
        }
    }


}