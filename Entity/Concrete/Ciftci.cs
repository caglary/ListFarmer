using Entity.Abstract;
using System;
using System.Collections.Generic;
namespace Entity.Concrete
{
    public class Ciftci : ICiftci
    {
        public Guid Id { get; set; }
        public string Tc { get; set; }
        private string _isim;
        private string _soyisim;
        private string _mahalle;
        public string Isim
        {
            get
            {
                return _isim;
            }
            set
            {
                _isim=value.ToUpper();
            }
        }
        public string Soyisim {
            get
            {
                return _soyisim;
            }
            set
            {
                _soyisim = value.ToUpper().Trim();
            }
        }
        public string Mahalle {
            get
            {
                return _mahalle;
            }
            set
            {
                _mahalle = value.ToUpper().Trim();
            }
        }
        public DateTime KayitTarih { get; set; }
        public string Aciklama { get; set; }
        public string Telefon { get; set; }
        public int DogumYili { get; set; }
        public string OlumTarihi { get; set; }
        public ICollection<Dilekce> Dilekce { get; set; }
    }
}
