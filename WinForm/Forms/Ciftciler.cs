using Business.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace WinForm.Forms
{
    public partial class Ciftciler : Form
    {
        CiftciServis _CiftciServis;
        public Ciftciler()
        {
            InitializeComponent();
            _CiftciServis = new CiftciServis();
        }
        private void Ciftciler_Load(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                Business.Concrete.DatabaseIslemleri.CreateDatabase();
                RefreshForm();
            });
        }
        public void RefreshForm()
        {
            dataGridView1.DataSource = _CiftciServis.GetAll();
            dataGridView1.Columns["Dilekce"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
            int dataGridRowCount = dataGridView1.RowCount;
            lblListeToplam.Text = $"Toplam çiftci sayısı:{dataGridRowCount}";
        }
        private void TxtTcNo_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
          
            StaticClass.Hata.tryCatch(() =>
            {
                
                List<Ciftci> ciftcilerListe = _CiftciServis.GetAll();
                var query = from c in ciftcilerListe
                            where c.Tc.Contains(textBox.Text)
                            select c;
                dataGridView1.DataSource = query.ToList();
            });
        }
        private void TxtIsim_TextChanged(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                TextBox textBox = (TextBox)sender;
                textBox.CharacterCasing = CharacterCasing.Lower;
                List<Ciftci> ciftcilerListe = _CiftciServis.GetAll();
                var query = from c in ciftcilerListe
                            where (c.Isim.ToLower()+" "+c.Soyisim.ToLower()).Contains((textBox.Text.ToUpper()).ToLower()) 
                            orderby c.Soyisim
                            select c;
                dataGridView1.DataSource = query.ToList();
            });
        }
        private void BtnDilekceShow_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                Form f = Application.OpenForms["Dilekce"];
                DataGridView d = dataGridView1;
                int rowindex = d.CurrentCell.RowIndex;
                Guid ciftciId = Guid.Parse(d.Rows[rowindex].Cells[0].Value.ToString());
                Ciftci gelenCiftci = _CiftciServis.Get(I => I.Id == ciftciId);
                if (gelenCiftci != null)
                {
                    if (f == null)
                    {
                        Dilekce dilekceform = new Dilekce(gelenCiftci);
                        dilekceform.ShowDialog();
                    }
                    else if (f != null)
                    {
                        f.Close();
                        Dilekce dilekceform = new Dilekce(gelenCiftci);
                        dilekceform.ShowDialog();
                    }
                }
                else
                {
                    //ciftci bulunamadı.
                }
            });
        }
        private void BtnYeniCiftciEkle_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                User kullanici = StaticClass.UserClass.WhichUser();
                if (kullanici.Add_Authority)
                {
                    Form form1 = Application.OpenForms["Form1"];
                    Form cbf = Application.OpenForms["CiftciBilgiFormu"];
                    if (cbf == null)
                    {
                        CiftciEkle ciftciEkleForm = new CiftciEkle();
                        ciftciEkleForm.MdiParent = form1;
                        ciftciEkleForm.Show();
                    }
                    else
                    {
                        cbf.Focus();
                    }
                }
                else
                    StaticClass.MessageBoxOperation.Unauthorized();
            });
        }
        private void BtnCiftciGuncelleSil_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                Guid selectedItemId = Guid.Parse(dataGridView1.Rows[rowIndex].Cells["Id"].Value.ToString());
                Ciftci ciftci = _CiftciServis.Get(I => I.Id == selectedItemId);
                if (ciftci != null)
                {
                    Form form1 = Application.OpenForms["Form1"];
                    Form ciftcilerGuncelleSil = Application.OpenForms["CiftcilerGuncelleSil"];
                    if (ciftcilerGuncelleSil == null)
                    {
                        CiftcilerGuncelleSil ciftcilerGuncelleSilForm = new CiftcilerGuncelleSil(ciftci);
                        ciftcilerGuncelleSilForm.MdiParent = form1;
                        ciftcilerGuncelleSilForm.Show();
                    }
                }
            });
        }
        private void BtnBackup_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                User kullanici = StaticClass.UserClass.WhichUser();
                StaticClass.UserClass.UserAuthoritiesValidation(() =>
                {
                    _CiftciServis.BackupJson();
                }, kullanici.Backup_Authority);
            });
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                Guid selectedItemId = Guid.Parse(dataGridView1.Rows[rowIndex].Cells["Id"].Value.ToString());
                Ciftci ciftci = _CiftciServis.Get(I => I.Id == selectedItemId);
                if (ciftci != null)
                {
                    Form form1 = Application.OpenForms["Form1"];
                    Form ciftcilerGuncelleSil = Application.OpenForms["CiftcilerGuncelleSil"];
                    if (ciftcilerGuncelleSil == null)
                    {
                        CiftcilerGuncelleSil ciftcilerGuncelleSilForm = new CiftcilerGuncelleSil(ciftci);
                        ciftcilerGuncelleSilForm.ShowDialog();
                    }
                }
            });
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                User user = StaticClass.UserClass.WhichUser();
                StaticClass.UserClass.UserAuthoritiesValidation(() =>
                {
                    StaticClass.MessageBoxOperation.MessageBoxWarning("Bu işlemi şu an gerçekleştiremessiniz.");
                }, user.Restore_Authority);
            });
        }
    }
}
