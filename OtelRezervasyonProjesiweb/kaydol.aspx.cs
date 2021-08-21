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
    public partial class kaydol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        protected void Button1_Click(object sender, EventArgs e)
        {
           
            bag.Open();
            SqlCommand cmd = new SqlCommand(@"insert into musteriler (adi,soyadi,yas,email,musteriadi,musterisifre) values(@Adi,
        @Soyadi,@Yas,@Email,@KullaniciAdi,@KullaniciSifre)", bag);
            cmd.Parameters.AddWithValue("Adi", TextBox1.Text);
            cmd.Parameters.AddWithValue("Soyadi", TextBox2.Text);
            cmd.Parameters.AddWithValue("Yas", TextBox3.Text);
            cmd.Parameters.AddWithValue("Email", TextBox4.Text);
            cmd.Parameters.AddWithValue("KullaniciAdi", TextBox5.Text);
            cmd.Parameters.AddWithValue("KullaniciSifre", TextBox6.Text);
            cmd.ExecuteNonQuery();
           bag.Close();

           Label8.Text = "Kayıt Başarıyla Tamamlandı";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("girisyap.aspx");

        }
    }
}