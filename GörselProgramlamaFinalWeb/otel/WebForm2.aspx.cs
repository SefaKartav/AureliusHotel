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
	public partial class WebForm2 : System.Web.UI.Page
	{
        MySqlConnection con = new MySqlConnection("Server=Localhost;Database=oteltrivela;Uid=root;Pwd=5252");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKayit_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKayitKullaniciAdi.Text.Trim();
            string sifre = txtKayitSifre.Text.Trim();
            string email = txtKayitEmail.Text.Trim();
            string tc = txtTc.Text.Trim();

            if (kullaniciAdi == "" || sifre == "" || email == "" || tc == "")
            {
                Response.Write("<script>alert('Lütfen tüm alanları doldurun.')</script>");
                return;
            }

            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO kullanicilar (kullanici_adi, tc, sifre, email) VALUES (@adi, @tc, @sifre, @mail)", con);
            cmd.Parameters.AddWithValue("@adi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.Parameters.AddWithValue("@mail", email);

            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Kayıt başarılı! Şimdi giriş yapabilirsiniz.'); setTimeout(function(){ switchTo('girisForm'); }, 1000);</script>");
            }
            catch (MySqlException ex)
            {
                Response.Write("<script>alert('Hata: " + ex.Message.Replace("'", "") + "');</script>");
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtGirisKullaniciAdi.Text.Trim();
            string sifre = txtGirisSifre.Text.Trim();

            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM kullanicilar WHERE kullanici_adi=@adi AND sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@adi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string ad = dr["kullanici_adi"].ToString();
                Session["kullanici"] = ad;

                if (ad.ToLower() == "admin")
                {
                    // Admin ise
                    string script = "<script>" +
                                    "alert('Admin girişi başarılı! Yönlendiriliyorsunuz...');" +
                                    "setTimeout(function() {" +
                                    "window.location.href = 'web-otel/Adminn.aspx';" +
                                    "});" +
                                    "</script>";
                    Response.Write(script);
                }
                else
                {
                    // Normal kullanıcı ise
                    string script = "<script>" +
                                    "alert('Giriş başarılı! Yönlendiriliyorsunuz...');" +
                                    "setTimeout(function() {" +
                                    "window.location.href = 'web-otel/otel.aspx';" +
                                    "});" +
                                    "</script>";
                    Response.Write(script);
                }
            }
            else
            {
                Response.Write("<script>alert('Kullanıcı adı veya şifre yanlış!');</script>");
            }

            con.Close();
        }
    }
}