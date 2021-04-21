using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Siniflar
{
    public class urunTuruTablosu
    {
        public List<Proje.DataAccess.urunTuruTablosu> Listele()
        {
            Proje.DataAccess.TeknikServisEntities nesne = new DataAccess.TeknikServisEntities();
            var sonuc = nesne.urunTuruTablosu.OrderBy(p => p.urunTuruId).ToList();
            return sonuc;
        }

        public string veriGirisi(Proje.DataAccess.urunTuruTablosu nesne) //burada urunTuruEkleme sayfasından verileri alabilmek için bir adet nesne oluşturduk, bu nesneyi hem burada hem orada kullanacağız
        {
            Proje.DataAccess.TeknikServisEntities entity = new DataAccess.TeknikServisEntities(); //entity nesnesi, iletişim için
            Proje.DataAccess.urunTuruTablosu ekleme = new DataAccess.urunTuruTablosu(); //verileri veritabanına eklemek için

            ekleme.urunTuruAdi = nesne.urunTuruAdi; //gelcek olan veri
            entity.urunTuruTablosu.Add(ekleme); //veritabanına ekle
            entity.SaveChanges();

            var veriListele = Listele();

            return "1";
        }
    }
}
