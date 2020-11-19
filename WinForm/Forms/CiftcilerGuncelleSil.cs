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
    public partial class CiftcilerGuncelleSil : Form
    {
        Ciftci gelenCiftci;
        Business.Concrete.CiftciServis ciftciServis;
        public CiftcilerGuncelleSil(Ciftci ciftci)
        {
            InitializeComponent();
            gelenCiftci = ciftci;
            ciftciServis = new Business.Concrete.CiftciServis();
        }
        private void CiftcilerGuncelleSil_Load(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                txtID.Text = gelenCiftci.Id.ToString();
                txtTcNumarasi.Text = gelenCiftci.Tc;
                txtIsim.Text = gelenCiftci.Isim;
                txtSoyisim.Text = gelenCiftci.Soyisim;
                txtMahalle.Text = gelenCiftci.Mahalle;
                txtAciklama.Text = gelenCiftci.Aciklama;
                txtTelefon.Text = gelenCiftci.Telefon;
                txtKayitTarihi.Text = gelenCiftci.KayitTarih.ToString();
            });
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                User kullanici = StaticClass.UserClass.WhichUser();
                StaticClass.UserClass.UserAuthoritiesValidation(() =>
                {
                    gelenCiftci.Isim = txtIsim.Text;
                    gelenCiftci.Tc = txtTcNumarasi.Text;
                    gelenCiftci.Soyisim = txtSoyisim.Text;
                    gelenCiftci.Mahalle = txtMahalle.Text;
                    gelenCiftci.Aciklama = txtAciklama.Text;
                    gelenCiftci.Telefon = txtTelefon.Text;
                    DialogResult result = StaticClass.MessageBoxOperation.MessageBoxQuestion("Güncelleme işlemine devam etmek istiyor musunuz?");
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            ciftciServis.Update(gelenCiftci);
                        }
                        catch (Exception exception)
                        {
                            StaticClass.MessageBoxOperation.MessageBoxError(exception.Message);
                        }
                        Form ciftcilerForm = Application.OpenForms["Ciftciler"];
                        if (ciftcilerForm != null)
                        {
                            DataGridView datagridview = (DataGridView)ciftcilerForm.Controls["dataGridView1"];
                            datagridview.DataSource = ciftciServis.GetAll();
                        }
                        this.Close();
                    }
                }, kullanici.Update_Authority);
            });
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() => { this.Close(); });
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                User kullanici = StaticClass.UserClass.WhichUser();
                StaticClass.UserClass.UserAuthoritiesValidation(() =>
                {
                     DialogResult result = StaticClass.MessageBoxOperation.MessageBoxQuestion("Çiftçiyi silemek istediğinize emin misiniz?");
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            ciftciServis.Delete(gelenCiftci);
                        }
                        catch (Exception exception)
                        {
                            StaticClass.MessageBoxOperation.MessageBoxError(exception.Message);
                        }
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
                        this.Close();
                    }
                }, kullanici.Delete_Authority);
                   
               
            });
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
    }
}
