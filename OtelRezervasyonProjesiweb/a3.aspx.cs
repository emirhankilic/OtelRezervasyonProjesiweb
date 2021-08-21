﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace OtelRezervasyonProjesiweb
{
    public partial class a3 : System.Web.UI.Page
    {
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button222_Click(object sender, EventArgs e)
        {
            Response.Redirect("anasayfa.aspx");
        }

        protected void Button111_Click(object sender, EventArgs e)
        {
            string odaidsi = "k103";
            try
            {
                string sorgu = "INSERT INTO rezervasyonistekleri VALUES(@tc,@ad,@syd,@grs,@cks,@odaid)";
                SqlCommand komut = new SqlCommand(sorgu, bag);
                komut.Parameters.AddWithValue("@tc", TextBox222.Text);
                komut.Parameters.AddWithValue("@ad", TextBox333.Text);
                komut.Parameters.AddWithValue("@syd", TextBox444.Text);
                komut.Parameters.AddWithValue("@grs", TextBox555.Text);
                komut.Parameters.AddWithValue("@cks", TextBox666.Text);
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