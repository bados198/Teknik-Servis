using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TeknikServis
{
    public partial class musteriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string baglantiIsimcigi = "Data Source=.\\SQLEXPRESS;Initial Catalog=TeknikServis;Integrated Security=True";
            //SqlConnection baglan = new SqlConnection(baglantiIsimcigi);

            //baglan.Open();

            //string sorgu = "insert into musteriTablosu (musteriAdSoyad, musteriTel, musteriAdr) values ('" + musteriAdSoyad.Text + "' , '"+musteriTel.Text+"' , '"+musteriAdr.Text+"')";

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


            Proje.Siniflar.musteriTablosu baglanti = new Proje.Siniflar.musteriTablosu(); //standart entity bağlantısı
            Proje.DataAccess.musteriTablosu veriAlma = new Proje.DataAccess.musteriTablosu(); //alacağım veriler için nesne bağlantısı

            try
            {
                veriAlma.musteriAdSoyad = musteriAdSoyad.Text;
                veriAlma.musteriTel = musteriTel.Text;
                veriAlma.musteriAdr = musteriAdr.Text;

                baglanti.veriGirisi(veriAlma);
                Label1.Text = "Veri Eklendi";
            }

            catch
            {
                Label1.Text = "Veri Veritabanına Eklenemedi, Sistemsel Hata";
            }
        }
    }
}