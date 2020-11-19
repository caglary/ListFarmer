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
    public partial class DilekceGuncelleSil : Form
    {
        Entity.Concrete.Dilekce _dilekce;
        Business.Concrete.DilekceServis dilekceServis;
        public DilekceGuncelleSil(Entity.Concrete.Dilekce dilekce)
        {
            InitializeComponent();
            _dilekce = dilekce;
            dilekceServis = new Business.Concrete.DilekceServis();
        }
        private void DilekceGuncelleSil_Load(object sender, EventArgs e)
        {
            lblDilekceId.Text = _dilekce.DilekceId.ToString();
            txtDilekceKabulTarihi.Text = _dilekce.DilekceKabulTarihi;
            txtDilekceTarihi.Text = _dilekce.DilekceTarihi;
            txtIlAdi.Text = _dilekce.IlAdi;
            txtIlceAdi.Text = _dilekce.IlceAdi;
            txtDilekceNumarasi.Text = _dilekce.DilekceNumarasi;
            cmbDurum.Text = _dilekce.Durum;
            cmbUretimYili.Text = _dilekce.UretimYili;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                User kullanici = StaticClass.UserClass.WhichUser();
                StaticClass.UserClass.UserAuthoritiesValidation(() =>
                {
                    try
                    {
                        dilekceServis.Update(new Entity.Concrete.Dilekce
                        {
                            CiftciId = _dilekce.CiftciId,
                            DilekceId = _dilekce.DilekceId,
                            DilekceKabulTarihi = txtDilekceKabulTarihi.Text,
                            DilekceNumarasi = txtDilekceNumarasi.Text,
                            DilekceTarihi = txtDilekceTarihi.Text,
                            Durum = cmbDurum.Text,
                            IlAdi = txtIlAdi.Text,
                            IlceAdi = txtIlceAdi.Text,
                            UretimYili = cmbUretimYili.Text
                        });
                    }
                    catch (Exception exception)
                    {
                        StaticClass.MessageBoxOperation.MessageBoxError(exception.Message);
                    }
                    //Bütün kayıtları çekiyruz.
                    var result = dilekceServis.GetAll();
                    // istediğimiz şarta uyan kayıtları listeliyoruz.
                    var resultConditoin = from I in result
                                          where I.CiftciId == _dilekce.CiftciId
                                          orderby I.UretimYili descending
                                          select I;
                    Form dilekce = Application.OpenForms["Dilekce"];
                    DataGridView datagrid = (DataGridView)dilekce.Controls["dataGridView1"];
                    datagrid.DataSource = resultConditoin.ToList();
                    DialogResult Soru = StaticClass.MessageBoxOperation.MessageBoxQuestion("Devam etmek istiyor musunuz?");
                    if (Soru == DialogResult.No)
                    {
                        this.Close();
                    }
                }, kullanici.Update_Authority);
            });
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                User kullanici = StaticClass.UserClass.WhichUser();
                StaticClass.UserClass.UserAuthoritiesValidation(() =>
                {
                    DialogResult Soru = StaticClass.MessageBoxOperation.MessageBoxQuestion("Devam etmek istiyor musunuz?");
                    if (Soru == DialogResult.Yes)
                    {
                        dilekceServis.Delete(_dilekce);
                        Form dilekce = Application.OpenForms["Dilekce"];
                        DataGridView datagrid = (DataGridView)dilekce.Controls["dataGridView1"];
                        datagrid.DataSource = dilekceServis.GetAllByCiftciId(_dilekce.CiftciId);
                        this.Close();
                    }
                }, kullanici.Delete_Authority);
            });
        }
    }
}
