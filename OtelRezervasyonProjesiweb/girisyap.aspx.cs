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
    public partial class girisyap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from musteriler where musteriadi=@KulAdi and musterisifre=@KulSifre", bag);
            da.SelectCommand.Parameters.Add("@KulAdi", SqlDbType.NVarChar, 11);
            da.SelectCommand.Parameters.Add("@KulSifre", SqlDbType.NVarChar, 8);
            da.SelectCommand.Parameters["@KulAdi"].Value = TextBox1.Text;
            da.SelectCommand.Parameters["@KulSifre"].Value = TextBox2.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
             Label4.Text = "Giriş Başarılı";
                Response.Redirect("anasayfa.aspx");
            }
            else
            {
                Label4.Text = "Hatalı Giriş Yaptınız!";
            }
        }
    }
}