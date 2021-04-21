using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Siniflar
{
    public class markaTablosu
    {
        public List<Proje.DataAccess.markaTablosu> Listele()
        {
            Proje.DataAccess.TeknikServisEntities nesne = new DataAccess.TeknikServisEntities();
            var sonuc = nesne.markaTablosu.OrderBy(p => p.markaId).ToList();
            return sonuc;
        }

        public string veriGirisi(Proje.DataAccess.markaTablosu nesne) //burada urunTuruEkleme sayfasından verileri alabilmek için bir adet nesne oluşturduk, bu nesneyi hem burada hem orada kullanacağız
        {
            Proje.DataAccess.TeknikServisEntities entity = new DataAccess.TeknikServisEntities(); //entity nesnesi, iletişim için
            Proje.DataAccess.markaTablosu ekleme = new DataAccess.markaTablosu(); //verileri veritabanına eklemek için

            ekleme.markaAdi = nesne.markaAdi;
            entity.markaTablosu.Add(ekleme); //veritabanına ekle
            entity.SaveChanges();

            var veriListele = Listele();

            return "1";
        }
    }
}
