using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Web.Services;

namespace otel.web_otel
{
    public partial class kullanıcıPanel : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection("Server=Localhost;Database=oteltrivela;Uid=root;Pwd=5252");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["kullanici"] != null)
                {
                    lblKullaniciAdi.Text = Session["kullanici"].ToString();
                    RezarvasyonlariGetir();
                }
                else
                {
                    Response.Redirect("WebForm2.aspx");
                }
            }
        }

        private void RezarvasyonlariGetir()
        {
            try
            {
                string kullaniciAdi = Session["kullanici"].ToString();
                con.Open();

                // Önce kullanicilar tablosundan kullanıcının tc'sini al
                MySqlCommand cmd1 = new MySqlCommand("SELECT tc FROM kullanicilar WHERE kullanici_adi = @kadi", con);
                cmd1.Parameters.AddWithValue("@kadi", kullaniciAdi);

                string kullaniciTc = cmd1.ExecuteScalar()?.ToString();

                if (!string.IsNullOrEmpty(kullaniciTc))
                {
                    // Rezervasyonları getir, id sütunu ile
                    MySqlCommand cmd2 = new MySqlCommand("SELECT id, ad, soyad, email, giris_tarihi, cikis_tarihi, oda_tipi, toplam_tutar FROM rezervasyonlar WHERE tcno = @tc ORDER BY id DESC", con);
                    cmd2.Parameters.AddWithValue("@tc", kullaniciTc);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Hata: " + ex.Message.Replace("'", "") + "')</script>");
            }
            finally
            {
                con.Close();
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // En son rezervasyonu belirlemek için (ilk satır, çünkü ORDER BY id DESC kullanıldı)
                if (e.Row.RowIndex == 0)
                {
                    // İptal butonunu bul
                    Button btnIptal = (Button)e.Row.FindControl("btnIptal");
                    if (btnIptal != null)
                    {
                        btnIptal.Visible = true; // Sadece en son rezervasyon için butonu göster
                    }
                }
            }
        }

        [WebMethod]
        public static string RezervasyonIptal(int id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("Server=Localhost;Database=oteltrivela;Uid=root;Pwd=515974"))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM rezervasyonlar WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "Rezervasyon başarıyla iptal edildi.";
                }
            }
            catch (Exception ex)
            {
                return "Hata: " + ex.Message.Replace("'", "");
            }
        }

        protected void btnCikis_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("otel.aspx");
        }
    }
}