using Database.Context;
using Entity.Concrete;
using System.Collections.Generic;
using System.Linq;
namespace Database.Operations
{
    public class DilekceDal : GenericRepository<Dilekce>
    {
        int ReturnValue = 0;
        public override int Add(Dilekce Entity)
        {
            //üretim yılını kontrol eder.
            bool result = UretimYiliKontrol(Entity);
            //eğer istenilen yıla ait bir dilekce varsa kayıt işlemi yapmaz ve bir hata fırlatır.
            //geriye 0 değerini döndürür.
            if (!result)
            {
                using (Context.DbTarimContext db=new DbTarimContext())
                {
                    db.Dilekceler.Add(Entity);
                    db.SaveChanges();
                }
            }
            else
            {
                throw new System.ArgumentException($"{ Entity.UretimYili } yılına ait dilekce mevcuttur.");
            }
            return ReturnValue;
        }
        public override int Update(Dilekce Entity)
        {
            //eğer dilekce varsa - üretim yılına ait-dilekce güncellenecek.
            var query = Get(I => I.CiftciId == Entity.CiftciId && I.DilekceId == Entity.DilekceId);
            if (query != null)
            {
                using (Context.DbTarimContext db = new DbTarimContext())
                {
                    var result = db.Dilekceler.Where(I => I.CiftciId == Entity.CiftciId && I.DilekceId == Entity.DilekceId).FirstOrDefault();
                    result.DilekceKabulTarihi = Entity.DilekceKabulTarihi;
                    result.DilekceNumarasi = Entity.DilekceNumarasi;
                    result.DilekceTarihi = Entity.DilekceTarihi;
                    result.IlAdi = Entity.IlAdi;
                    result.IlceAdi = Entity.IlceAdi;
                    result.UretimYili = Entity.UretimYili;
                    result.Durum = Entity.Durum;
                    ReturnValue = db.SaveChanges();
                }
            }
            return ReturnValue;
        }
       
        public bool UretimYiliKontrol(Dilekce Entity)
        {
            var query = Get(I => I.UretimYili == Entity.UretimYili && I.CiftciId == Entity.CiftciId);
            if (query == null) return false;
            else return true;
        }
        public List<Liste> DilekceGetirByUretimYili(string uretimYili)
        {
            using (var context = new DbTarimContext())
            {
                string query = "select Dilekceler.[Dilekce Numarası] as DilekceNumarasi,Ciftciler.[TC Numarası] as Tc,Ciftciler.Isim as Isim,Ciftciler.Soyisim as Soyisim,Ciftciler.Mahalle as Mahalle,Dilekceler.[Dilekce Tarihi] as Tarih,Ciftciler.Acıklama as Aciklama from Ciftciler full join Dilekceler on Ciftciler.[Ciftci ID]=Dilekceler.[Çiftci ID] where Dilekceler.[Üretim Yılı]  ='" + uretimYili + "' order by DilekceNumarasi desc";
                return context.Database.SqlQuery<Entity.Concrete.Liste>(query).ToList();
            }
        }
    }
}
