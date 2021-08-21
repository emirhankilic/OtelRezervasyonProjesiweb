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
    public partial class a4 : System.Web.UI.Page
    {
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2222_Click(object sender, EventArgs e)
        {
            Response.Redirect("anasayfa.aspx");
        }

        protected void Button1111_Click(object sender, EventArgs e)
        {
            string odaidsi = "k201";
            try
            {
                string sorgu = "INSERT INTO rezervasyonistekleri VALUES(@tc,@ad,@syd,@grs,@cks,@odaid)";
                SqlCommand komut = new SqlCommand(sorgu, bag);
                komut.Parameters.AddWithValue("@tc", TextBox2222.Text);
                komut.Parameters.AddWithValue("@ad", TextBox3333.Text);
                komut.Parameters.AddWithValue("@syd", TextBox4444.Text);
                komut.Parameters.AddWithValue("@grs", TextBox5555.Text);
                komut.Parameters.AddWithValue("@cks", TextBox6666.Text);
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