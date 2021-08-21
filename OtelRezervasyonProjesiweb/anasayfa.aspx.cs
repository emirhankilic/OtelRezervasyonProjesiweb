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
    public partial class anasayfa : System.Web.UI.Page
    {
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        public void k101()
        {
            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [fiyat] from [odabilgi] where [id]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", "k101");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = dr["fiyat"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [salon] from [odabilgi] where [id]=@veri2", bag);
            cmd3.Parameters.AddWithValue("@veri2", "k101");
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                Label4.Text = dr3["salon"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [oda] from [odabilgi] where [id]=@veri2", bag);
            cmd4.Parameters.AddWithValue("@veri2", "k101");
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                Label6.Text = dr4["oda"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [balkon] from [odabilgi] where [id]=@veri2", bag);
            cmd5.Parameters.AddWithValue("@veri2", "k101");
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                Label10.Text = dr5["balkon"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [havuz] from [odabilgi] where [id]=@veri2", bag);
            cmd6.Parameters.AddWithValue("@veri2", "k101");
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                Label12.Text = dr6["havuz"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd7 = new SqlCommand("select [extradolap] from [odabilgi] where [id]=@veri2", bag);
            cmd7.Parameters.AddWithValue("@veri2", "k101");
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                Label14.Text = dr7["extradolap"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd8 = new SqlCommand("select [manzara] from [odabilgi] where [id]=@veri2", bag);
            cmd8.Parameters.AddWithValue("@veri2", "k101");
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                Label17.Text = dr8["manzara"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd9 = new SqlCommand("select [jakuzi] from [odabilgi] where [id]=@veri2", bag);
            cmd9.Parameters.AddWithValue("@veri2", "k101");
            SqlDataReader dr9 = cmd9.ExecuteReader();
            if (dr9.Read())
            {
                Label19.Text = dr9["jakuzi"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd10 = new SqlCommand("select [dus] from [odabilgi] where [id]=@veri2", bag);
            cmd10.Parameters.AddWithValue("@veri2", "k101");
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                Label21.Text = dr10["dus"].ToString();
            }
            bag.Close();



        }
        public void k102()
        {
            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [fiyat] from [odabilgi] where [id]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", "k102");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                Label23.Text = dr["fiyat"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [salon] from [odabilgi] where [id]=@veri2", bag);
            cmd3.Parameters.AddWithValue("@veri2", "k102");
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                Label25.Text = dr3["salon"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [oda] from [odabilgi] where [id]=@veri2", bag);
            cmd4.Parameters.AddWithValue("@veri2", "k102");
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                Label27.Text = dr4["oda"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [balkon] from [odabilgi] where [id]=@veri2", bag);
            cmd5.Parameters.AddWithValue("@veri2", "k102");
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                Label29.Text = dr5["balkon"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [havuz] from [odabilgi] where [id]=@veri2", bag);
            cmd6.Parameters.AddWithValue("@veri2", "k102");
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                Label31.Text = dr6["havuz"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd7 = new SqlCommand("select [extradolap] from [odabilgi] where [id]=@veri2", bag);
            cmd7.Parameters.AddWithValue("@veri2", "k102");
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                Label33.Text = dr7["extradolap"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd8 = new SqlCommand("select [manzara] from [odabilgi] where [id]=@veri2", bag);
            cmd8.Parameters.AddWithValue("@veri2", "k102");
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                Label35.Text = dr8["manzara"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd9 = new SqlCommand("select [jakuzi] from [odabilgi] where [id]=@veri2", bag);
            cmd9.Parameters.AddWithValue("@veri2", "k102");
            SqlDataReader dr9 = cmd9.ExecuteReader();
            if (dr9.Read())
            {
                Label37.Text = dr9["jakuzi"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd10 = new SqlCommand("select [dus] from [odabilgi] where [id]=@veri2", bag);
            cmd10.Parameters.AddWithValue("@veri2", "k102");
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                Label39.Text = dr10["dus"].ToString();
            }
            bag.Close();



        }
        public void k103()
        {
            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [fiyat] from [odabilgi] where [id]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", "k103");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                Label41.Text = dr["fiyat"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [salon] from [odabilgi] where [id]=@veri2", bag);
            cmd3.Parameters.AddWithValue("@veri2", "k103");
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                Label45.Text = dr3["salon"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [oda] from [odabilgi] where [id]=@veri2", bag);
            cmd4.Parameters.AddWithValue("@veri2", "k103");
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                Label49.Text = dr4["oda"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [balkon] from [odabilgi] where [id]=@veri2", bag);
            cmd5.Parameters.AddWithValue("@veri2", "k103");
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                Label53.Text = dr5["balkon"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [havuz] from [odabilgi] where [id]=@veri2", bag);
            cmd6.Parameters.AddWithValue("@veri2", "k103");
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                Label57.Text = dr6["havuz"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd7 = new SqlCommand("select [extradolap] from [odabilgi] where [id]=@veri2", bag);
            cmd7.Parameters.AddWithValue("@veri2", "k103");
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                Label61.Text = dr7["extradolap"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd8 = new SqlCommand("select [manzara] from [odabilgi] where [id]=@veri2", bag);
            cmd8.Parameters.AddWithValue("@veri2", "k103");
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                Label65.Text = dr8["manzara"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd9 = new SqlCommand("select [jakuzi] from [odabilgi] where [id]=@veri2", bag);
            cmd9.Parameters.AddWithValue("@veri2", "k103");
            SqlDataReader dr9 = cmd9.ExecuteReader();
            if (dr9.Read())
            {
                Label69.Text = dr9["jakuzi"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd10 = new SqlCommand("select [dus] from [odabilgi] where [id]=@veri2", bag);
            cmd10.Parameters.AddWithValue("@veri2", "k103");
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                Label73.Text = dr10["dus"].ToString();
            }
            bag.Close();



        }
        public void k201()
        {

            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [fiyat] from [odabilgi] where [id]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", "k201");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                Label43.Text = dr["fiyat"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [salon] from [odabilgi] where [id]=@veri2", bag);
            cmd3.Parameters.AddWithValue("@veri2", "k201");
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                Label47.Text = dr3["salon"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [oda] from [odabilgi] where [id]=@veri2", bag);
            cmd4.Parameters.AddWithValue("@veri2", "k201");
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                Label51.Text = dr4["oda"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [balkon] from [odabilgi] where [id]=@veri2", bag);
            cmd5.Parameters.AddWithValue("@veri2", "k201");
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                Label55.Text = dr5["balkon"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [havuz] from [odabilgi] where [id]=@veri2", bag);
            cmd6.Parameters.AddWithValue("@veri2", "k201");
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                Label59.Text = dr6["havuz"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd7 = new SqlCommand("select [extradolap] from [odabilgi] where [id]=@veri2", bag);
            cmd7.Parameters.AddWithValue("@veri2", "k201");
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                Label63.Text = dr7["extradolap"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd8 = new SqlCommand("select [manzara] from [odabilgi] where [id]=@veri2", bag);
            cmd8.Parameters.AddWithValue("@veri2", "k201");
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                Label67.Text = dr8["manzara"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd9 = new SqlCommand("select [jakuzi] from [odabilgi] where [id]=@veri2", bag);
            cmd9.Parameters.AddWithValue("@veri2", "k201");
            SqlDataReader dr9 = cmd9.ExecuteReader();
            if (dr9.Read())
            {
                Label71.Text = dr9["jakuzi"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd10 = new SqlCommand("select [dus] from [odabilgi] where [id]=@veri2", bag);
            cmd10.Parameters.AddWithValue("@veri2", "k201");
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                Label75.Text = dr10["dus"].ToString();
            }
            bag.Close();


        }
        public void k202()
        {
            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [fiyat] from [odabilgi] where [id]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", "k202");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                Label77.Text = dr["fiyat"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [salon] from [odabilgi] where [id]=@veri2", bag);
            cmd3.Parameters.AddWithValue("@veri2", "k202");
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                Label81.Text = dr3["salon"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [oda] from [odabilgi] where [id]=@veri2", bag);
            cmd4.Parameters.AddWithValue("@veri2", "k202");
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                Label85.Text = dr4["oda"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [balkon] from [odabilgi] where [id]=@veri2", bag);
            cmd5.Parameters.AddWithValue("@veri2", "k202");
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                Label89.Text = dr5["balkon"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [havuz] from [odabilgi] where [id]=@veri2", bag);
            cmd6.Parameters.AddWithValue("@veri2", "k202");
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                Label93.Text = dr6["havuz"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd7 = new SqlCommand("select [extradolap] from [odabilgi] where [id]=@veri2", bag);
            cmd7.Parameters.AddWithValue("@veri2", "k202");
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                Label97.Text = dr7["extradolap"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd8 = new SqlCommand("select [manzara] from [odabilgi] where [id]=@veri2", bag);
            cmd8.Parameters.AddWithValue("@veri2", "k202");
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                Label101.Text = dr8["manzara"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd9 = new SqlCommand("select [jakuzi] from [odabilgi] where [id]=@veri2", bag);
            cmd9.Parameters.AddWithValue("@veri2", "k202");
            SqlDataReader dr9 = cmd9.ExecuteReader();
            if (dr9.Read())
            {
                Label105.Text = dr9["jakuzi"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd10 = new SqlCommand("select [dus] from [odabilgi] where [id]=@veri2", bag);
            cmd10.Parameters.AddWithValue("@veri2", "k202");
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                Label109.Text = dr10["dus"].ToString();
            }
            bag.Close();


        }
        public void k203()
        {
            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [fiyat] from [odabilgi] where [id]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", "k203");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                Label79.Text = dr["fiyat"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [salon] from [odabilgi] where [id]=@veri2", bag);
            cmd3.Parameters.AddWithValue("@veri2", "k203");
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                Label83.Text = dr3["salon"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [oda] from [odabilgi] where [id]=@veri2", bag);
            cmd4.Parameters.AddWithValue("@veri2", "k203");
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                Label87.Text = dr4["oda"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [balkon] from [odabilgi] where [id]=@veri2", bag);
            cmd5.Parameters.AddWithValue("@veri2", "k203");
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                Label91.Text = dr5["balkon"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [havuz] from [odabilgi] where [id]=@veri2", bag);
            cmd6.Parameters.AddWithValue("@veri2", "k203");
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                Label95.Text = dr6["havuz"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd7 = new SqlCommand("select [extradolap] from [odabilgi] where [id]=@veri2", bag);
            cmd7.Parameters.AddWithValue("@veri2", "k203");
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                Label99.Text = dr7["extradolap"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd8 = new SqlCommand("select [manzara] from [odabilgi] where [id]=@veri2", bag);
            cmd8.Parameters.AddWithValue("@veri2", "k203");
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                Label103.Text = dr8["manzara"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd9 = new SqlCommand("select [jakuzi] from [odabilgi] where [id]=@veri2", bag);
            cmd9.Parameters.AddWithValue("@veri2", "k203");
            SqlDataReader dr9 = cmd9.ExecuteReader();
            if (dr9.Read())
            {
                Label107.Text = dr9["jakuzi"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd10 = new SqlCommand("select [dus] from [odabilgi] where [id]=@veri2", bag);
            cmd10.Parameters.AddWithValue("@veri2", "k203");
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                Label111.Text = dr10["dus"].ToString();
            }
            bag.Close();


        }
        protected void Page_Load(object sender, EventArgs e)
        {
            k101();
            k102();
            k103();
            k201();
            k202();
            k203();



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("a1.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("a2.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("a3.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("a4.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("a5.aspx");
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("a6.aspx");
        }
    }
}