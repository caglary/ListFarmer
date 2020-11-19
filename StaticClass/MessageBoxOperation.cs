using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StaticClass
{
   public static class MessageBoxOperation
    {
        public static DialogResult MessageBoxError(string Message)
        {
            return MessageBox.Show(Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult MessageBoxInformation(string Message)
        {
            return MessageBox.Show(Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult MessageBoxWarning(string Message)
        {
            return MessageBox.Show(Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult MessageBoxQuestion(string Message)
        {
            return MessageBox.Show(Message, "Soru", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
        public static DialogResult Unauthorized()
        {
            return MessageBox.Show("Yetkiniz bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
