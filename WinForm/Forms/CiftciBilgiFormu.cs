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
    public partial class CiftciBilgiFormu : Form
    {
        Business.Concrete.CiftciServis ciftciServis;

        public CiftciBilgiFormu()
        {
            InitializeComponent();
            ciftciServis = new Business.Concrete.CiftciServis();
        }

        private void CiftciBilgiFormu_Load(object sender, EventArgs e)
        {
            txtID.Text = Guid.NewGuid().ToString();
            txtKayitTarihi.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Ciftci ciftci = CreateCiftci();

            ciftciServis.Ekle(ciftci);

            Temizle();

            Form ciftcilerForm = Application.OpenForms["Ciftciler"];
            if (ciftcilerForm != null)
            {
                DataGridView datagridview = (DataGridView)ciftcilerForm.Controls["dataGridView1"];
                datagridview.DataSource = ciftciServis.ListeGetir();
            }
            DialogResult result = StaticClass.Helper.MessageBoxQuestion("Yeni kayıt işlemine deva etmek ister misiniz?");
            if (result == DialogResult.No)
            {
                this.Close();
                ciftcilerForm.Focus();
            }


        }



        private void Temizle()
        {
            txtID.Text = Guid.NewGuid().ToString();
            txtKayitTarihi.Text = DateTime.Now.ToShortDateString();
            txtTcNumarasi.Text = "";
            txtIsim.Text = "";
            txtSoyisim.Text = "";
            txtMahalle.Text = "";
            txtAciklama.Text = "";
            txtTelefon.Text = "";
        }

        private Ciftci CreateCiftci()
        {
            Ciftci c = new Ciftci();
            c.Id = Guid.Parse(txtID.Text);
            c.Tc = txtTcNumarasi.Text;
            c.Isim = txtIsim.Text;
            c.Soyisim = txtSoyisim.Text;
            c.Mahalle = txtMahalle.Text;
            c.KayitTarih = Convert.ToDateTime(txtKayitTarihi.Text);
            c.Aciklama = txtAciklama.Text;
            c.Telefon = txtTelefon.Text;
            return c;
        }
    }
}
