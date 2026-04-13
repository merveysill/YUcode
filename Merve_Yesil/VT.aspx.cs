using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Merve_Yesil
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["oturum"] != null)
            {
                GridView1.Visible = true;

            }
            else
            {
                GridView1.Visible = false;
            }
        }
    }
}