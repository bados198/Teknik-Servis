using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Siniflar
{
    public class musteriTablosu
    {
        public List<Proje.DataAccess.musteriTablosu> Listele()
        {
            Proje.DataAccess.TeknikServisEntities nesne = new DataAccess.TeknikServisEntities();
            var sonuc = nesne.musteriTablosu.OrderBy(p => p.musteriId).ToList();
            return sonuc;
        }

        public string veriGirisi(Proje.DataAccess.musteriTablosu nesne) //burada urunTuruEkleme sayfasından verileri alabilmek için bir adet nesne oluşturduk, bu nesneyi hem burada hem orada kullanacağız
        {
            Proje.DataAccess.TeknikServisEntities entity = new DataAccess.TeknikServisEntities(); //entity nesnesi, iletişim için
            Proje.DataAccess.musteriTablosu ekleme = new DataAccess.musteriTablosu(); //verileri veritabanına eklemek için

            ekleme.musteriAdSoyad = nesne.musteriAdSoyad;
            ekleme.musteriTel = nesne.musteriTel;
            ekleme.musteriAdr = nesne.musteriAdr;
            entity.musteriTablosu.Add(ekleme); //veritabanına ekle
            
            entity.SaveChanges();
            var veriListele = Listele();

            return "1";
        }
    }
}
