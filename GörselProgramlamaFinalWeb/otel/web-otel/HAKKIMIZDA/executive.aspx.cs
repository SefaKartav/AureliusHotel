using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace otel.web_otel.HAKKIMIZDA
{
	public partial class executive : System.Web.UI.Page
	{
        MySqlConnection con = new MySqlConnection("Server=Localhost;Database=oteltrivela;Uid=root;Pwd=5252");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                YorumlariGetir();
            }
        }


        protected void btnYorumGonder_Click(object sender, EventArgs e)
        {
            if (Session["kullanici"] == null)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "uyari", "alert('Yorum yapabilmek için giriş yapmalısınız.');", true);
                return;
            }

            string kullaniciAdi = Session["kullanici"].ToString();
            string yorum = txtYorum.Text.Trim();
            int puan = Convert.ToInt32(ddlPuan.SelectedValue);
            string odaAdi = "EXECUTIVE CLUB ODA";
            DateTime tarih = DateTime.Now;

            if (string.IsNullOrEmpty(yorum))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "uyari", "alert('Yorum boş olamaz.');", true);
                return;
            }

            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO yorumlar (kullanici_adi, yorum, puan, oda_adi, tarih) VALUES (@kullanici, @yorum, @puan, @oda, @tarih)", con);
            cmd.Parameters.AddWithValue("@kullanici", kullaniciAdi);
            cmd.Parameters.AddWithValue("@yorum", yorum);
            cmd.Parameters.AddWithValue("@puan", puan);
            cmd.Parameters.AddWithValue("@oda", odaAdi);
            cmd.Parameters.AddWithValue("@tarih", tarih);
            cmd.ExecuteNonQuery();
            con.Close();

            txtYorum.Text = "";
            ddlPuan.SelectedIndex = 0;

            YorumlariGetir();

            ScriptManager.RegisterStartupScript(this, GetType(), "basarili", "alert('Yorum başarıyla eklendi!');", true);
        }

        private void YorumlariGetir()
        {
            string odaAdi = "EXECUTIVE CLUB ODA";
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT kullanici_adi, yorum, puan, tarih FROM yorumlar WHERE oda_adi = @oda ORDER BY id DESC", con);
            cmd.Parameters.AddWithValue("@oda", odaAdi);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            rptYorumlar.DataSource = dt;
            rptYorumlar.DataBind();
        }
    }
}