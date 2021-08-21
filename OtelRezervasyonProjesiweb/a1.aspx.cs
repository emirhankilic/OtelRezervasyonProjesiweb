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
    public partial class a1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        protected void Button1_Click(object sender, EventArgs e)
        {
            string odaidsi = "k101";
            try
            {
                string sorgu = "INSERT INTO rezervasyonistekleri VALUES(@tc,@ad,@syd,@grs,@cks,@odaid)";
                SqlCommand komut = new SqlCommand(sorgu, bag);
                komut.Parameters.AddWithValue("@tc", TextBox2.Text);
                komut.Parameters.AddWithValue("@ad", TextBox3.Text);
                komut.Parameters.AddWithValue("@syd", TextBox4.Text);
                komut.Parameters.AddWithValue("@grs", TextBox5.Text);
                komut.Parameters.AddWithValue("@cks", TextBox6.Text);
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("anasayfa.aspx");
        }
    }
}