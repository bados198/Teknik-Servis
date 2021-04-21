using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TeknikServis
{
    public partial class markaGoster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string baglantiIsimcigi = "Data Source=.\\SQLEXPRESS;Initial Catalog=TeknikServis;Integrated Security=True";
            //SqlConnection baglan = new SqlConnection(baglantiIsimcigi);

            //baglan.Open();

            //string sorgu = "select * from markaTablosu";
            //SqlCommand komut = new SqlCommand(sorgu, baglan);
            //SqlDataReader dr = komut.ExecuteReader();

            //try
            //{
            //    GridView1.DataSource = dr;
            //    GridView1.DataBind();
            //    Label1.Text = "Veritabanı Bağlantısı Sağlandı";
            //}
            //catch
            //{
            //    Label1.Text = "Veritabanı Bağlantısında Hata";
            //}

            //baglan.Close();


            Proje.Siniflar.markaTablosu nesne = new Proje.Siniflar.markaTablosu();

            GridView1.DataSource = nesne.Listele();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}