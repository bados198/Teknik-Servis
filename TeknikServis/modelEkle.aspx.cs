using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TeknikServis
{
    public partial class modelEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string baglantiIsimcigi = "Data Source=.\\SQLEXPRESS;Initial Catalog=TeknikServis;Integrated Security=True";
            //SqlConnection baglan = new SqlConnection(baglantiIsimcigi);

            //baglan.Open();

            //string sorgu = "insert into modelTablosu (urunTuruFkId, markaFkId, modelSeri, modelAdi) values ('" + TextBox1.Text + "' , '" + TextBox2.Text + "' , '" + TextBox3.Text + "' , '" + TextBox4.Text + "')";

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

            Proje.Siniflar.modelTablosu baglanti = new Proje.Siniflar.modelTablosu();
            Proje.DataAccess.modelTablosu veriAlma = new Proje.DataAccess.modelTablosu();

            try
            {
                veriAlma.urunTuruFkId = Convert.ToInt32(TextBox1.Text);
                veriAlma.markaFkId = Convert.ToInt32(TextBox2.Text);
                veriAlma.modelSeri = TextBox3.Text;
                veriAlma.modelAdi = TextBox4.Text;
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