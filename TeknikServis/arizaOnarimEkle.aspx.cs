using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TeknikServis
{
    public partial class arizaOnarimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string baglantiIsimcigi = "Data Source=.\\SQLEXPRESS;Initial Catalog=TeknikServis;Integrated Security=True";
            //SqlConnection baglan = new SqlConnection(baglantiIsimcigi);

            //baglan.Open();
            //string onarimTar = DateTime.Now.ToString();

            //string sorgu = "insert into onarimTablosu (arizaFkId, onarimNedeni, onarimTeshisTar, onarimTar, onarimUcret) values ('" + arizaFkId.Text + "' , '" + onarimNedeni.Text + "' , '"+onarimTeshisTar.Text+"', '" + onarimTeshisTar + "', '"+onarimUcret.Text+"')";

            //try
            //{
            //    SqlCommand komut = new SqlCommand(sorgu, baglan);
            //    komut.ExecuteNonQuery();
            //    Label1.Text = "Ekleme Başarılı";
            //}

            //catch
            //{
            //    Label1.Text = "Veritabanına Veri Eklenemedi";
            //}
            //baglan.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

            Proje.Siniflar.onarimTablosu baglanti = new Proje.Siniflar.onarimTablosu();
            Proje.DataAccess.onarimTablosu veriAlma = new Proje.DataAccess.onarimTablosu();

            try
            {
                veriAlma.arizaFkId = Convert.ToInt32(arizaFkId.Text);
                veriAlma.onarimTeshisTar = DateTime.Now;
                veriAlma.onarimNedeni = onarimNedeni.Text;
                veriAlma.onarimTar = DateTime.Now;
                veriAlma.onarimUcret = onarimUcret.Text;


                baglanti.veriGirisi(veriAlma);
                Label1.Text = "Veri Ekleme Başarılı";
            }

            catch
            {
                Label1.Text = "Veritabanına Veri Eklenemedi, Sistemsel Arıza";
            }
        }
    }
}