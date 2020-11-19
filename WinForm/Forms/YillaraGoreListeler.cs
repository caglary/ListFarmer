using Business.Concrete;
using Entity.Concrete;
using StaticClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace WinForm.Forms
{
    public partial class YillaraGoreListeler : Form
    {
        CiftciServis ciftciServis;
        DilekceServis dilekceServis;
        static string yil = string.Empty;
        List<YeniTip> yeniTipListe = null;
        public YillaraGoreListeler()
        {
            InitializeComponent();
            ciftciServis = new CiftciServis();
            dilekceServis = new DilekceServis();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            EditButtonColorInGroupBox(sender as Button);
            Button btn = sender as Button;
            yil = btn.Text;
            yeniTipListe = Liste(yil);
            dgwListeler.DataSource = yeniTipListe;
            labelToplamKisiSayisi.Text = dgwListeler.Rows.Count.ToString();
            lblBaslik.Text = btn.Text+" ÇKS Listesi";
            lblBaslik.BackColor = Color.Azure;
            lblBaslik.ForeColor = Color.DarkRed;
            
           
        }
        private void EditButtonColorInGroupBox(Button button)
        {
            foreach (var item in this.groupBoxMenu.Controls)
            {
                if (item is Button)
                {
                    Button btnItem = item as Button;
                    if (button.Text == btnItem.Text)
                    {
                        button.BackColor = Color.Yellow;
                    }
                    else
                    {
                        btnItem.BackColor = Color.White;
                    }
                }
            }
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                User kullanici = StaticClass.UserClass.WhichUser();
                StaticClass.UserClass.UserAuthoritiesValidation(() =>
                {
                    var liste = dgwListeler.DataSource;
                    FolderBrowserDialog _folder = new FolderBrowserDialog();
                    DialogResult result = _folder.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string _folderPath = _folder.SelectedPath;
                        //string jsonObject = Helper.JsonSerialize(liste);
                        string jsonObject = Newtonsoft.Json.JsonConvert.SerializeObject(liste);
                        string SavePath = _folderPath + "\\" + lblBaslik.Text + ".json";
                        File.WriteAllText(SavePath, jsonObject);
                        MessageBoxOperation.MessageBoxInformation($"{_folderPath} adresine backup işlemi yapıldı.");
                    }
                }, kullanici.Backup_Authority);
            });
        }
        private void btnToExcel_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                User kullanici = StaticClass.UserClass.WhichUser();
                StaticClass.UserClass.UserAuthoritiesValidation(() =>
                {
                    StaticClass.ExcelOperation.DatagridToExcel(dgwListeler);
                }, kullanici.Excel_Authority);
            });
        }
        private void YillaraGoreListeler_Load(object sender, EventArgs e)
        {
            btn_Click(btn2020, e);
        }
        private void txtIsim_TextChanged(object sender, EventArgs e)
        {
            var textBoxText = txtIsim.Text.ToUpper(new CultureInfo("tr-TR", false));
            var result = from i in yeniTipListe
                         where i.Isim.Contains(textBoxText)
                         select i;
            dgwListeler.DataSource = result.ToList();
        }
        List<YeniTip> Liste(string yil)
        {
            List<Entity.Concrete.Dilekce> dilekceler = dilekceServis.GetAll();
            List<Ciftci> ciftciler = ciftciServis.GetAll();
            List<YeniTip> yeniListe = new List<YeniTip>();
            var innerJoin = from _ciftci in ciftciler
                            join _dilekce in dilekceler
                            on _ciftci.Id equals _dilekce.CiftciId
                            where _dilekce.UretimYili == yil
                            orderby Convert.ToDateTime(_dilekce.DilekceTarihi) descending
                            select new
                            {
                                DilekceNo = _dilekce.DilekceNumarasi,
                                TCNo = _ciftci.Tc,
                                Isim = _ciftci.Isim + " " + _ciftci.Soyisim,
                                MahalleKoy = _ciftci.Mahalle,
                                KayitTarihi = _dilekce.DilekceTarihi
                            };
            foreach (var item in innerJoin)
            {
                YeniTip kayit = new YeniTip();
                try
                {
                    kayit.DilekceNo = Convert.ToInt32(item.DilekceNo);
                }
                catch (Exception)
                {
                    kayit.DilekceNo = 0;
                }
                kayit.Isim = item.Isim;
                kayit.MahalleKoy = item.MahalleKoy;
                kayit.Tarih = Convert.ToDateTime(item.KayitTarihi);
                kayit.TcNo = item.TCNo;
                yeniListe.Add(kayit);
            }
            return yeniListe.OrderByDescending(I=>I.DilekceNo).ToList();
        }
        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            var result = from i in yeniTipListe
                         where i.TcNo.Contains(txtTcNo.Text)
                         select i;
            dgwListeler.DataSource = result.ToList();
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
    class YeniTip
    {
        public int DilekceNo { get; set; }
        public string TcNo { get; set; }
        public string Isim { get; set; }
        public string MahalleKoy { get; set; }
        public DateTime Tarih { get; set; }
    }
}
