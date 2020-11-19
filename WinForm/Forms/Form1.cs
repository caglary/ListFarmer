using System;
using System.IO;
using System.Windows.Forms;
using WinForm.Forms;
namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCiftciler_Click(object sender, EventArgs e)
        {
            Form f = new Ciftciler();
            OpenForm(ref f);
        }
        private void btnListeler_Click(object sender, EventArgs e)
        {
            Form formListeler = new YillaraGoreListeler();
            OpenForm(ref formListeler);
        }
        private void btnFks_Click(object sender, EventArgs e)
        {
            Form f = new FksMgd();
            OpenForm(ref f);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblConnectionStringInfo.Text = Business.Concrete.DatabaseIslemleri.ConnectionStringofConnection();
            this.Text = $"Hoşgeldin {StaticClass.UserClass.WhichUser().Name}";
            lblKarsılama.Text = this.Text;
            lblDatetime.Text = DateTime.Now.ToShortDateString();
        }
        /// <summary>
        /// Formları açmak için kullanılır.Ref olarak gönderilen parametre formu açar.Eğer form açıksa tekrardan açmaz.
        /// </summary>
        /// <param name="form"></param>
        void OpenForm(ref Form form)
        {
            Form f = form;
            foreach (Form mdiChild in MdiChildren)
            {
                if (mdiChild.Text == f.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }
            f.MdiParent = this;
            f.Show();
        }
    }
}
