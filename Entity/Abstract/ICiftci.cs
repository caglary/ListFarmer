using System;
namespace Entity.Abstract
{
    public interface ICiftci
    {
        Guid Id { get; set; }
        string Tc { get; set; }
        string Isim { get; set; }
        string Soyisim { get; set; }
        string Mahalle { get; set; }
        DateTime KayitTarih { get; set; }
        string Aciklama { get; set; }
        string Telefon { get; set; }
        
    }
}
