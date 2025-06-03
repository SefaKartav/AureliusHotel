using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace otel.web_otel
{
	public partial class Adminn : System.Web.UI.Page
	{
        MySqlConnection con = new MySqlConnection("Server=Localhost;Database=oteltrivela;Uid=root;Pwd=5252");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnARA_Click(object sender, EventArgs e)
        {
            string tc = txtInput.Text; 
            string query = "SELECT * FROM rezervasyonlar WHERE tcno = @tcno";

            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tcno", tc);
            adapter = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                
                TextBox1.Text = dt.Rows[0]["ad"].ToString();
                TextBox2.Text = dt.Rows[0]["soyad"].ToString();
                TextBox3.Text = dt.Rows[0]["email"].ToString();
                TextBox4.Text = dt.Rows[0]["telefon"].ToString();
                TextBox5.Text = Convert.ToDateTime(dt.Rows[0]["giris_tarihi"]).ToString("yyyy-MM-dd");
                TextBox6.Text = Convert.ToDateTime(dt.Rows[0]["cikis_tarihi"]).ToString("yyyy-MM-dd");
                TextBox7.Text = dt.Rows[0]["oda_tipi"].ToString();
                TextBox8.Text = dt.Rows[0]["gun_sayisi"].ToString() + "Gün";
                TextBox9.Text = dt.Rows[0]["toplam_tutar"].ToString() + " €";
                TextBox10.Text = Convert.ToDateTime(dt.Rows[0]["kayit_tarihi"]).ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                
                Response.Write("<script>alert('Kayıt bulunamadı.');</script>");
            }

        }

        protected void btnSIL_Click(object sender, EventArgs e)
        {
            string tc = txtInput.Text;
            string query = "DELETE FROM rezervasyonlar WHERE tcno = @tcno";

            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tcno", tc);

            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();

            if (result > 0)
            {
                Response.Write("<script>alert('Kayıt başarıyla silindi.');</script>");

                
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Silinecek kayıt bulunamadı.');</script>");
            }

        }
    }
}