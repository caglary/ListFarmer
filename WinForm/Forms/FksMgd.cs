using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace WinForm.Forms
{
    public partial class FksMgd : Form
    {
        Business.Concrete.FksServis _fksServis;
        Business.Concrete.MgdServis _mgdServis;
        public FksMgd()
        {
            InitializeComponent();
            _fksServis = new Business.Concrete.FksServis();
            _mgdServis = new Business.Concrete.MgdServis();
        }
        private void Fks_Load(object sender, EventArgs e)
        {
            txtTc.Focus();
            txtTc.SelectionStart = 0;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> seneler = new List<string> { "2017", "2018", "2019" };
            List<Fks> fksListesi = new List<Fks>();
            List<Mgd> mgdListesi = new List<Mgd>();
            foreach (var sene in seneler)
            {
                Fks fksInfo = _fksServis.CiftciFksGetir(sene, txtTc.Text);
                if (fksInfo != null)
                {
                    fksInfo.ilce = sene;
                    fksListesi.Add(fksInfo);
                }
            }
            foreach (var sene in seneler)
            {
                Mgd mgdInfo = _mgdServis.CiftciMgdGetir(sene, txtTc.Text);
                if (mgdInfo != null)
                {
                    mgdInfo.ilce = sene;
                    mgdListesi.Add(mgdInfo);
                }
            }
            dataGridViewFks.DataSource = fksListesi;
            dataGridViewFks.Columns["id"].Visible = false;
            dataGridViewFks.Columns["siraNo"].Visible = false;
            dataGridViewFks.Columns["il"].Visible = false;
            dataGridViewFks.Columns["isletmeNo"].Visible = false;
            dataGridViewFks.Columns["dilekceNo"].Visible = false;
            dataGridViewFks.Columns["ilce"].HeaderText = "Yıl";
            dataGridViewMgd.DataSource = mgdListesi;
            dataGridViewMgd.Columns["id"].Visible = false;
            dataGridViewMgd.Columns["siraNo"].Visible = false;
            dataGridViewMgd.Columns["il"].Visible = false;
            dataGridViewMgd.Columns["tc"].Visible = false;
            dataGridViewMgd.Columns["dilekceNo"].Visible = false;
            dataGridViewMgd.Columns["ilce"].HeaderText = "Yıl";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() => { this.Close(); });
        }
    }
}
