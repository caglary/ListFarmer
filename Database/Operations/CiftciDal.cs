using Database.Context;
using Entity.Concrete;
using System.Linq;
namespace Database.Operations
{
    public class CiftciDal : GenericRepository<Ciftci>
    {
        public override int Update(Ciftci item)
        {
            int returnValue = 0;
            using (var context = new DbTarimContext())
            {
                var result = context.Ciftciler.SingleOrDefault(b => b.Id == item.Id);
                if (result != null)
                {
                    result.Tc = item.Tc;
                    result.Isim = item.Isim;
                    result.Soyisim = item.Soyisim;
                    result.Mahalle = item.Mahalle;
                    result.Telefon = item.Telefon;
                    result.Aciklama = item.Aciklama;
                    returnValue = context.SaveChanges();
                }
            }
            return returnValue;
        }
    }
}
