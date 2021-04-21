using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Siniflar
{
    public class modelTablosu
    {
        public List<Proje.DataAccess.modelTablosu> Listele()
        {
            Proje.DataAccess.TeknikServisEntities ent = new DataAccess.TeknikServisEntities();
            var sonuc = ent.modelTablosu.OrderBy(p => p.modelId).ToList();
            return sonuc;
        }

        public string veriGirisi(Proje.DataAccess.modelTablosu nesne) //burada urunTuruEkleme sayfasından verileri alabilmek için bir adet nesne oluşturduk, bu nesneyi hem burada hem orada kullanacağız
        {
            Proje.DataAccess.TeknikServisEntities entity = new DataAccess.TeknikServisEntities(); //entity nesnesi, iletişim için
            Proje.DataAccess.modelTablosu ekleme = new DataAccess.modelTablosu(); //verileri veritabanına eklemek için

            ekleme.urunTuruFkId = nesne.urunTuruFkId;
            ekleme.markaFkId = nesne.markaFkId;
            ekleme.modelSeri = nesne.modelSeri;
            ekleme.modelAdi = nesne.modelAdi;
            
            entity.modelTablosu.Add(ekleme); //veritabanına ekle
            entity.SaveChanges();

            var veriListele = Listele();

            return "1";
        }

    }
}
