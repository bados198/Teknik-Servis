using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TeknikServis
{
    public partial class arizaliUrunEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string baglantiIsimcigi = "Data Source=.\\SQLEXPRESS;Initial Catalog=TeknikServis;Integrated Security=True";
            SqlConnection baglan = new SqlConnection(baglantiIsimcigi);

            baglan.Open();
            string arizaGelisTar = DateTime.Now.ToString();

            string sorgu = "insert into arizaTablosu (modelFkId, musteriFkId, arizaNedeni, arizaGelisTar) values ('" + modelFkId.Text + "' , '" + musteriFkId.Text + "' , '" + arizaNedeni.Text + "', '"+arizaGelisTar+"')";

            try
            {
                SqlCommand komut = new SqlCommand(sorgu, baglan);
                komut.ExecuteNonQuery();
                Label1.Text = "Ekleme Başarılı";
            }

            catch
            {
                Label1.Text = "Veritabanına Veri Eklenemedi";
            }
            baglan.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Proje.Siniflar.arizaTablosu baglanti = new Proje.Siniflar.arizaTablosu();
            Proje.DataAccess.arizaTablosu veriAlma = new Proje.DataAccess.arizaTablosu();

            try
            {
                veriAlma.modelFkId = Convert.ToInt32(modelFkId.Text);
                veriAlma.musteriFkId = Convert.ToInt32(musteriFkId.Text);
                veriAlma.arizaNedeni = arizaNedeni.Text;
                veriAlma.arizaGelisTar = DateTime.Now;

                Label1.Text = "Veri Eklendi";
            }

            catch
            {
                Label1.Text = "Veriler Veritabanına Eklenemedi, Sistemsel Arıza";
            }
        }
    }
}