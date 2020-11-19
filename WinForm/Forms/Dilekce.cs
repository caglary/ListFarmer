using Business.Concrete;
using Entity.Concrete;
using System;
using System.Linq;
using System.Windows.Forms;
namespace WinForm.Forms
{
    public partial class Dilekce : Form
    {
        public Ciftci _ciftci { get; set; }
        DilekceServis dilekceServis;
        public Dilekce(Ciftci ciftci)
        {
            InitializeComponent();
            _ciftci = ciftci;
            dilekceServis = new DilekceServis();
        }
        private void Dilekce_Load(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                this.Text = $" {_ciftci.Isim} {_ciftci.Soyisim}";
                var liste = dilekceServis.GetAll();
                var istenenListe = from I in liste
                                   where I.CiftciId == _ciftci.Id
                                   orderby I.UretimYili descending
                                   select I;
                dataGridView1.DataSource = istenenListe.ToList();
                dataGridView1.Columns["DilekceId"].Visible = false;
                dataGridView1.Columns["CiftciId"].Visible = false;
                dataGridView1.Columns["Ciftci"].Visible = false;
            });
        }
        private void btnDilekceEkle_Click(object sender, EventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                User kullanici = StaticClass.UserClass.WhichUser();
                if (kullanici.Add_Authority)
                {
                    Form dilekceEkle = new DilekceEkle(_ciftci);
                    dilekceEkle.ShowDialog();
                }
                else
                    StaticClass.MessageBoxOperation.Unauthorized();
            });
        }
        private void btnDilekceUpdateDelete_Click(object sender, EventArgs e)
        {
            User kullanici = StaticClass.UserClass.WhichUser();
            if (kullanici.Update_Authority)
            {
                try
                {
                    int rowIndex = dataGridView1.CurrentRow.Index;
                    int dilekceId = (int)dataGridView1.Rows[rowIndex].Cells["DilekceId"].Value;
                    var dilekce = dilekceServis.Get(I => I.DilekceId == dilekceId);
                    Form dilekceGuncelleSil = new DilekceGuncelleSil(dilekce);
                    dilekceGuncelleSil.ShowDialog();
                }
                catch (NullReferenceException exception)
                {
                    StaticClass.MessageBoxOperation.MessageBoxInformation("Listeden işlem yapmak istediğiniz dilekceyi seçiniz.");
                }
            }
            else
                StaticClass.MessageBoxOperation.Unauthorized();
        }
        private void Dilekce_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaticClass.Hata.tryCatch(() =>
            {
                Form f = Application.OpenForms["Ciftciler"];
                //ciftciler kontrolleri arasında gezecek.
                foreach (var item in f.Controls)
                {
                    //panel controlü bulacak.
                    if (item is Panel)
                    {
                        Panel panel = (Panel)item;
                        //panelin controlleri arasında gezecek.
                        foreach (var items in panel.Controls)
                        {
                            //textbox lar içerisinde gezecek.
                            if (items is TextBox)
                            {
                                TextBox textBox = (TextBox)items;
                                //istenilen textbox bulunacak.
                                if (textBox.Name == "txtTcNo")
                                {
                                    //yapılmak istenenler kodlanacak.
                                    //textbox içerisinde imlec başa gelip yanıp yanıp sonecek. 
                                    //coding ....
                                }
                            }
                        }
                    }
                }
            });
        }
    }
}
