using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace OtelRezervasyonProjesiweb
{
    public partial class a5 : System.Web.UI.Page
    {
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button111_Click(object sender, EventArgs e)
        {

        }

        protected void Button22222_Click(object sender, EventArgs e)
        {
            Response.Redirect("anasayfa.aspx");
        }

        protected void Button11111_Click(object sender, EventArgs e)
        {
            string odaidsi = "k202";
            try
            {
                string sorgu = "INSERT INTO rezervasyonistekleri VALUES(@tc,@ad,@syd,@grs,@cks,@odaid)";
                SqlCommand komut = new SqlCommand(sorgu, bag);
                komut.Parameters.AddWithValue("@tc", TextBox22222.Text);
                komut.Parameters.AddWithValue("@ad", TextBox33333.Text);
                komut.Parameters.AddWithValue("@syd", TextBox44444.Text);
                komut.Parameters.AddWithValue("@grs", TextBox55555.Text);
                komut.Parameters.AddWithValue("@cks", TextBox66666.Text);
                komut.Parameters.AddWithValue("@odaid", odaidsi);

                bag.Open();
                komut.ExecuteNonQuery();
                bag.Close();
                Response.Write("REZERVASYON İSTEĞİNİZ BAŞARIYLA İLETİLDİ");
            }
            catch (Exception hata)
            {
                if (bag.State == ConnectionState.Open) bag.Close();
                Response.Write(hata.Message);
            }
        }
    }
}