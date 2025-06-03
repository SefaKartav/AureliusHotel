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
	public partial class WebForm1 : System.Web.UI.Page
	{
        MySqlConnection con = new MySqlConnection("Server=Localhost;Database=oteltrivela;Uid=root;Pwd=5252");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
		{

		}
        private void CalculateTotalAmount()
        {
            try
            {
                DateTime girisTarihi, cikisTarihi;
                if (!DateTime.TryParse(TextBoxGirisTarihi.Text, out girisTarihi) ||
                    !DateTime.TryParse(TextBoxCikisTarihi.Text, out cikisTarihi))
                {
                    Label1.Text = "Toplam Tutar: 0 €";
                    return;
                }

                int gunSayisi = (cikisTarihi - girisTarihi).Days;
                if (gunSayisi <= 0)
                {
                    Label1.Text = "Toplam Tutar: 0 €";
                    return;
                }

                string odaTipi = "";
                double fiyat = 0;

                if (RadioButton1.Checked)
                {
                    odaTipi = "STANDART ODA";
                    fiyat = 125.00;
                }
                else if (RadioButton2.Checked)
                {
                    odaTipi = "DELUXE ODA";
                    fiyat = 135.00;
                }
                else if (RadioButton3.Checked)
                {
                    odaTipi = "EXECUTIVE CLUB ODA";
                    fiyat = 145.00;
                }
                else if (RadioButton4.Checked)
                {
                    odaTipi = "SUPERIOR ODA";
                    fiyat = 155.00;
                }
                else if (RadioButton5.Checked)
                {
                    odaTipi = "PRESIDENTIAL SUIT";
                    fiyat = 170.00;
                }
                else
                {
                    Label1.Text = "Toplam Tutar: 0 €";
                    return;
                }

                double toplamTutar = gunSayisi * fiyat;
                Label1.Text = $"Toplam Tutar: {toplamTutar:N2} €";
            }
            catch (Exception ex)
            {
                Label1.Text = "Toplam Tutar: 0 €";
                Response.Write("<script>alert('Hata: " + ex.Message.Replace("'", "") + "')</script>");
            }
        }

        protected void TextBoxGirisTarihi_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        protected void TextBoxCikisTarihi_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        protected void TextBoxAd_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxTCNo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonRezervasyonYap_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime girisTarihi, cikisTarihi;
                if (!DateTime.TryParse(TextBoxGirisTarihi.Text, out girisTarihi) ||
                    !DateTime.TryParse(TextBoxCikisTarihi.Text, out cikisTarihi))
                {
                    Response.Write("<script>alert('Tarih formatı hatalı.')</script>");
                    return;
                }

                int gunSayisi = (cikisTarihi - girisTarihi).Days;
                if (gunSayisi <= 0)
                {   
                    Response.Write("<script>alert('Geçerli tarih aralığı girin.')</script>");
                    return;
                }

                string odaTipi = "";
                double fiyat = 0;

                if (RadioButton1.Checked)
                {
                    odaTipi = "STANDART ODA";
                    fiyat = 125.00;
                }
                else if (RadioButton2.Checked)
                {
                    odaTipi = "DELUXE ODA";
                    fiyat = 135.00;
                }
                else if (RadioButton3.Checked)
                {
                    odaTipi = "EXECUTIVE CLUB ODA";
                    fiyat = 145.00;
                }
                else if (RadioButton4.Checked)
                {
                    odaTipi = "SUPERIOR ODA";
                    fiyat = 155.00;
                }
                else if (RadioButton5.Checked)
                {
                    odaTipi = "PRESIDENTIAL SUIT";
                    fiyat = 170.00;
                }
                else
                {
                    Response.Write("<script>alert('Lütfen bir oda tipi seçiniz.')</script>");
                    return;
                }

                double toplamTutar = gunSayisi * fiyat;

                Label1.Text = $"Toplam Tutar: {toplamTutar:N2} €";

                string ad = TextBoxAd.Text.Trim();
                string soyad = TextBoxSoyad.Text.Trim();
                string email = TextBoxEmail.Text.Trim();
                string tcno = TextBoxTCNo.Text.Trim();
                string telefon = TextBoxTelefon.Text.Trim();

                string query = @"INSERT INTO rezervasyonlar
            (ad, soyad, email, tcno, telefon, giris_tarihi, cikis_tarihi, oda_tipi, gun_sayisi, toplam_tutar)
            VALUES
            (@ad, @soyad, @email, @tcno, @telefon, @giris, @cikis, @oda, @gun, @tutar)";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@tcno", tcno);
                    cmd.Parameters.AddWithValue("@telefon", telefon);
                    cmd.Parameters.AddWithValue("@giris", girisTarihi.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@cikis", cikisTarihi.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@oda", odaTipi);
                    cmd.Parameters.AddWithValue("@gun", gunSayisi);
                    cmd.Parameters.AddWithValue("@tutar", toplamTutar);

                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();

                    if (result > 0)
                    {
                        Response.Write("<script>alert('Rezervasyon başarıyla kaydedildi.')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Veritabanına eklenemedi.')</script>");
                    }
                }
                Session["rez_ad"] = TextBoxAd.Text.Trim();
                Session["rez_soyad"] = TextBoxSoyad.Text.Trim();
                Session["rez_email"] = TextBoxEmail.Text.Trim();
                Session["rez_tcno"] = TextBoxTCNo.Text.Trim();
                Session["rez_telefon"] = TextBoxTelefon.Text.Trim();
                Session["rez_giris"] = girisTarihi;
                Session["rez_cikis"] = cikisTarihi;
                Session["rez_oda"] = odaTipi;
                Session["rez_gun"] = gunSayisi;
                Session["rez_tutar"] = toplamTutar;

                // Ödeme sayfasına yönlendir
                Response.Redirect("odeme.aspx");
            }
            catch (Exception ex)
            {
                con.Close(); // Bağlantı açıksa kapat
                Response.Write("<script>alert('Hata: " + ex.Message.Replace("'", "") + "')</script>");
            }

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }
        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }
        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }
    }
}