using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinForm.Forms
{
    public partial class CiftciEkle : Form
    {
        Business.Concrete.CiftciServis ciftciServis;
        int ReturnValueInt;
        public CiftciEkle()
        {
            InitializeComponent();
            ciftciServis = new Business.Concrete.CiftciServis();
        }
        private void CiftciBilgiFormu_Load(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                txtID.Text = Guid.NewGuid().ToString();
                txtKayitTarihi.Text = DateTime.Now.ToShortDateString();
            });
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                User kullanici = StaticClass.UserClass.WhichUser();
                StaticClass.UserClass.UserAuthoritiesValidation(() =>
                {
                    Ciftci ciftci = CreateCiftci();
                    ReturnValueInt = ciftciServis.Add(ciftci);
                    if (ReturnValueInt == 1)
                    {
                        StaticClass.MessageBoxOperation.MessageBoxInformation("Ekleme işlemi başarılı");
                    }
                    Temizle();
                    Form ciftcilerForm = Application.OpenForms["Ciftciler"];
                    if (ciftcilerForm != null)
                    {
                        DataGridView datagridview = (DataGridView)ciftcilerForm.Controls["dataGridView1"];
                        datagridview.DataSource = ciftciServis.GetAll();
                        int dataGridRowCount = datagridview.RowCount;
                        Panel panel1 = (Panel)ciftcilerForm.Controls["Panel1"];
                        Label lblListeToplam = (Label)panel1.Controls["lblListeToplam"];
                        lblListeToplam.Text = $"Toplam çiftci sayısı:{dataGridRowCount}";
                    }
                    DialogResult result = StaticClass.MessageBoxOperation.MessageBoxQuestion("Yeni kayıt işlemine deva etmek ister misiniz?");
                    if (result == DialogResult.No)
                    {
                        this.Close();
                        ciftcilerForm.Focus();
                    }
                }, kullanici.Add_Authority);
            });
        }
        private void Temizle()
        {
            StaticClass.Hata.tryCatch(() =>
            {
                txtID.Text = Guid.NewGuid().ToString();
                txtKayitTarihi.Text = DateTime.Now.ToShortDateString();
                txtTcNumarasi.Text = "";
                txtIsim.Text = "";
                txtSoyisim.Text = "";
                txtMahalle.Text = "";
                txtAciklama.Text = "";
                txtDogumYili.Text = "";
            });
        }
        private Ciftci CreateCiftci()
        {
            Ciftci c = new Ciftci();
            c.Id = Guid.Parse(txtID.Text);
            c.Tc = txtTcNumarasi.Text;
            c.Isim = txtIsim.Text.Trim();
            c.Soyisim = txtSoyisim.Text.Trim();
            c.Mahalle = txtMahalle.Text;
            c.KayitTarih = Convert.ToDateTime(txtKayitTarihi.Text);
            c.Aciklama = txtAciklama.Text;
            c.Telefon = txtTelefonNumarasi.Text;
            c.DogumYili = int.Parse(txtDogumYili.Text);
            return c;
        }
        private void txtEnter(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                TextBox T = (TextBox)sender;
                T.BackColor = Color.LightYellow;
            });
        }
        private void txtLeave(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                TextBox T = (TextBox)sender;
                T.BackColor = Color.White;
            });
        }
        private void btnTcKimlikNoDogrula_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                Ciftci ciftci = CreateCiftci();
                if (!string.IsNullOrEmpty(txtTcNumarasi.Text) && !string.IsNullOrEmpty(txtIsim.Text) &&
                    !string.IsNullOrEmpty(txtSoyisim.Text) && !string.IsNullOrEmpty(txtDogumYili.Text))
                {
                    StaticClass.TCKimlikNo tCKimlikNo = new StaticClass.TCKimlikNo();
                    bool result = tCKimlikNo.Dogrula(long.Parse(ciftci.Tc), ciftci.Isim.ToUpper(), ciftci.Soyisim.ToUpper(), ciftci.DogumYili);
                    if (result)
                        StaticClass.MessageBoxOperation.MessageBoxInformation("Kişi bilgileri doğrudur.");
                    else
                        StaticClass.MessageBoxOperation.MessageBoxError("Girilen bilgilerde HATA var.");
                }
                else
                {
                    StaticClass.MessageBoxOperation.MessageBoxWarning("Tc Numarası, İsim, Soyisim, Doğum Yılı alanlarını kontrol ediniz.Bu alanlar boş geçilemez.");
                }
            });
        }
    }
}
