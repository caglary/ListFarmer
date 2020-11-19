using Entity.Concrete;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace Business.Concrete
{
    public class Restore
    {
        Business.Concrete.CiftciServis _ciftciServis;
        public Restore()
        {
            _ciftciServis = new CiftciServis();
        }
        public void RestoreCiftciler()
        {
            //json dosyasından veriler çekilecek
            //Json dosyasının uzantısını öğreniyoruz.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string folderPath = ofd.FileName;
            //json string çeviriyoruz.
            string JsonOkunanData = File.ReadAllText(folderPath);
            //okunan değeri listeye çeviriyoruz.
            List<Ciftci> ciftciler = StaticClass.JsonOperation.JsonDeserialize<Ciftci>(JsonOkunanData);
            //loglama yapmak için iki liste daha oluşturuyoruz.
            List<Ciftci> eklenenKayitlar = new List<Ciftci>();
            List<Ciftci> guncellenenKayitlar = new List<Ciftci>();
            int logGuncellenenKayitSayisi = 0, logEklenenKayitSayisi = 0;
            //gelen verinin tc si ile bir sorgulama yapılacak
            foreach (var item in ciftciler)
            {
                Ciftci ciftci = _ciftciServis.Get(I => I.Tc == item.Tc);
                if (ciftci != null)
                {
                    // içeride kayıt ver demektir. güncelleme işlemi yapılackak.
                    _ciftciServis.Update(item);
                    string logGuncellenenKayitlar = $"{item.Tc} {item.Isim} {item.Soyisim} {item.Mahalle} {item.KayitTarih} {item.Aciklama} {item.Telefon}";
                    logGuncellenenKayitSayisi++;
                    guncellenenKayitlar.Add(item);
                }
                else if (ciftci == null)
                {
                    //içeride kayıt yok demektir. yeni kayıt ekleme işlemi yapılacak.
                    _ciftciServis.Add(item);
                    string logEklenenKayitlar = $"{item.Tc} {item.Isim} {item.Soyisim} {item.Mahalle} {item.KayitTarih} {item.Aciklama} {item.Telefon}";
                    logEklenenKayitSayisi++;
                    eklenenKayitlar.Add(item);
                }
            }
            int ToplamDüzenlenenkayitSayisi = logGuncellenenKayitSayisi + logEklenenKayitSayisi;
            StaticClass.MessageBoxOperation.MessageBoxInformation($"Toplam düzenlenen kayıt:{ToplamDüzenlenenkayitSayisi.ToString()}\n" +
                $"Eklenen Kayıt:{logEklenenKayitSayisi.ToString()}\n" +
                $"Guncellenen Kayıt:{logGuncellenenKayitSayisi.ToString()}");
            //eklenen ve guncelenen kayıtların listelerini bir dosyaya yazdıracağız.
            string dosya_yolu_eklenen_kayitlar = @"EkleneKayitlar.txt";
            string dosya_yolu_guncellenen_kayitlar = @"GuncellenenKayitlar.txt";
            string folderPathKayitlar = StaticClass.FileOperation.FolderPath();
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(folderPathKayitlar + "\\" + dosya_yolu_eklenen_kayitlar, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            foreach (var item in eklenenKayitlar)
            {
                string kayit = $"{item.Id} {item.Tc} {item.Isim} {item.Soyisim} {item.Mahalle} {item.Telefon} {item.KayitTarih}";
                sw.WriteLine(kayit);
            }
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            FileStream fsGuncellenen = new FileStream(folderPathKayitlar + "\\" + dosya_yolu_guncellenen_kayitlar, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter swGuncellenen = new StreamWriter(fsGuncellenen);
            foreach (var item in guncellenenKayitlar)
            {
                string kayit = $"{item.Id} {item.Tc} {item.Isim} {item.Soyisim} {item.Mahalle} {item.Telefon} {item.KayitTarih}";
                swGuncellenen.WriteLine(kayit);
            }
            swGuncellenen.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            swGuncellenen.Close();
            fsGuncellenen.Close();
        }
    }
}
