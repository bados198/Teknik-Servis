using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Siniflar
{
    public class arizaTablosu
    {
        public List<Proje.DataAccess.arizaTablosu> Listele()
        {
            Proje.DataAccess.TeknikServisEntities nesne = new DataAccess.TeknikServisEntities();
            var sonuc = nesne.arizaTablosu.OrderBy(p => p.arizaId).ToList();
            return sonuc;
        }

        public string veriGirisi(Proje.DataAccess.arizaTablosu nesne) //burada urunTuruEkleme sayfasından verileri alabilmek için bir adet nesne oluşturduk, bu nesneyi hem burada hem orada kullanacağız
        {
            Proje.DataAccess.TeknikServisEntities entity = new DataAccess.TeknikServisEntities(); //entity nesnesi, iletişim için
            Proje.DataAccess.arizaTablosu ekleme = new DataAccess.arizaTablosu(); //verileri veritabanına eklemek için

            ekleme.modelFkId = nesne.modelFkId;
            ekleme.musteriFkId = nesne.musteriFkId;
            ekleme.arizaNedeni = nesne.arizaNedeni;
            ekleme.arizaGelisTar = nesne.arizaGelisTar;

            entity.arizaTablosu.Add(ekleme); //veritabanına ekle
            entity.SaveChanges();

            var veriListele = Listele();

            return "1";
        }
    }
}
