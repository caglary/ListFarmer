using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StaticClass
{
    public class TCKimlikNo
    {
        public bool Dogrula(long TCKimlikNo, string Ad, string Soyad, int DogumYili)
        {
            TCKimlikNoDogrula.KPSPublic kPSPublic = new TCKimlikNoDogrula.KPSPublic();
            return kPSPublic.TCKimlikNoDogrula(TCKimlikNo, Ad, Soyad, DogumYili);
        }
    }
}
