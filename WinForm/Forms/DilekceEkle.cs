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
    public partial class DilekceEkle : Form
    {
        Ciftci _ciftci;
        Business.Concrete.DilekceServis dilekceServis;
        public DilekceEkle(Ciftci ciftci)
        {
            InitializeComponent();
            _ciftci = ciftci;
            dilekceServis = new Business.Concrete.DilekceServis();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Dilekce = Application.OpenForms["Dilekce"];
            Dilekce.Focus();
        }
        private void DilekceEkle_Load(object sender, EventArgs e)
        {
            txtDilekceTarihi.Text = DateTime.Now.ToShortDateString();
            txtDilekceKabulTarihi.Text = DateTime.Now.ToShortDateString();
            txtIlAdi.Text = "ORDU";
            txtIlceAdi.Text = "AYBASTI";
            cmbDurum.SelectedIndex = 2;
            cmbUretimYili.SelectedIndex = 1;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() => { 
            
              User kullanici = StaticClass.UserClass.WhichUser();
            StaticClass.UserClass.UserAuthoritiesValidation(() =>
            {
                Entity.Concrete.Dilekce dilekce = new Entity.Concrete.Dilekce();
                dilekce.CiftciId = _ciftci.Id;
                dilekce.DilekceKabulTarihi = txtDilekceKabulTarihi.Text;
                dilekce.DilekceTarihi = txtDilekceTarihi.Text;
                dilekce.Durum = cmbDurum.Text;
                dilekce.IlAdi = txtIlAdi.Text;
                dilekce.IlceAdi = txtIlceAdi.Text;
                dilekce.UretimYili = cmbUretimYili.Text;
                dilekce.DilekceNumarasi = txtDilekceNumarasi.Text;
                try
                {
                    dilekceServis.Add(dilekce);
                }
                catch (Exception exception)
                {
                    StaticClass.MessageBoxOperation.MessageBoxError(exception.Message);
                }
                Form form = Application.OpenForms["Dilekce"];
                DataGridView datagrid = (DataGridView)form.Controls["datagridview1"];
                datagrid.DataSource = dilekceServis.GetAllByCiftciId(_ciftci.Id);
                DialogResult soru = StaticClass.MessageBoxOperation.MessageBoxQuestion("Devam etmek istiyor musunuz?");
                if (soru == DialogResult.No)
                {
                    this.Close();
                }
            }, kullanici.Add_Authority);
            
            });
          
        }
    }
}
