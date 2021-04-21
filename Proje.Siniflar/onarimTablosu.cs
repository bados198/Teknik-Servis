using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Siniflar
{
    public class onarimTablosu
    {
        public List<Proje.DataAccess.onarimTablosu> Listele()
        {
            Proje.DataAccess.TeknikServisEntities nesne = new DataAccess.TeknikServisEntities();
            var sonuc = nesne.onarimTablosu.OrderBy(p => p.onarimId).ToList();
            return sonuc;
        }

        public string veriGirisi(Proje.DataAccess.onarimTablosu nesne) //burada urunTuruEkleme sayfasından verileri alabilmek için bir adet nesne oluşturduk, bu nesneyi hem burada hem orada kullanacağız
        {
            Proje.DataAccess.TeknikServisEntities entity = new DataAccess.TeknikServisEntities(); //entity nesnesi, iletişim için
            Proje.DataAccess.onarimTablosu ekleme = new DataAccess.onarimTablosu(); //verileri veritabanına eklemek için

            ekleme.arizaFkId = nesne.arizaFkId;
            ekleme.onarimNedeni = nesne.onarimNedeni;
            ekleme.onarimTeshisTar = nesne.onarimTeshisTar;
            ekleme.onarimTar = nesne.onarimTar;
            ekleme.onarimUcret = nesne.onarimUcret;
            entity.onarimTablosu.Add(ekleme); //veritabanına ekle
            entity.SaveChanges();

            var veriListele = Listele();

            return "1";
        }
    }
}
