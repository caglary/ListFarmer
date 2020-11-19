using Entity.Abstract;
using System;
namespace Entity.Concrete
{
    public class Dilekce : IDilekce
    {
        public int DilekceId { get; set; }
        public string DilekceNumarasi { get; set; }
        public string UretimYili { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string DilekceTarihi { get; set; }
        public string DilekceKabulTarihi { get; set; }
        public string Durum { get; set; }
        public Guid CiftciId { get; set; }
        public Ciftci Ciftci { get; set; }
    }
}
