using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace otel
{
	public partial class otel : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection("Server=Localhost;Database=oteltrivela;Uid=root;Pwd=5252");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                if (Session["kullanici"] != null) // Giriş yapmışsa
                {
                    HyperLinkLogin.Text = "Kullanıcı Paneli";
                    HyperLinkLogin.NavigateUrl = "kullanıcıPanel.aspx"; // Kullanıcı Paneli Sayfası
                }
                else // Giriş yapılmamışsa
                {
                    HyperLinkLogin.Text = "Giriş Yap";
                    HyperLinkLogin.NavigateUrl = "/WebForm2.aspx"; // Giriş Sayfası
                }
            }
        }
       
    }
}