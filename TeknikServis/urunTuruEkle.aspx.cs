using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TeknikServis
{
    public partial class urunTuruEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string baglantiIsimcigi = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabaniAnaBaglantisi"].ConnectionString;     //KLASİK VERİTABANINA VERİ EKLEME YÖNTEMİ
            //SqlConnection baglan = new SqlConnection(baglantiIsimcigi);

            //baglan.Open();

            //string sorgu = "insert into urunTuruTablosu (urunTuruAdi) values ('" + TextBox1.Text + "')";

            //SqlCommand komut = new SqlCommand(sorgu, baglan);
            //komut.ExecuteNonQuery();
            //baglan.Close();

            Proje.Siniflar.urunTuruTablosu baglanti = new Proje.Siniflar.urunTuruTablosu();
            Proje.DataAccess.urunTuruTablosu veriAlma = new Proje.DataAccess.urunTuruTablosu();

            try
            {
                veriAlma.urunTuruAdi = TextBox1.Text;
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