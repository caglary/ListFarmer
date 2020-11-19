using System.Net.Mail;
using System.Text;
namespace StaticClass
{
    public static class SendEmail
    {
        public static void SendMailToGmail(string emailSubject, string emailBody,   string mailAdressDiplayName,
            string emailpassword,string dosyaYolu = null, string emailUsername= "caglar.yurdakul60@gmail.com",  string to = "caglar.yurdakul60@gmail.com", string mailAdress = "caglar.yurdakul60@gmail.com" )
        {
            Encoding encode = Encoding.GetEncoding("windows-1254");//türkçe karakter sorunu yaşamamk  için 
            MailMessage Email = new MailMessage();
            Email.To.Add(to);
            //"caglar.yurdakul60@gmail.com", "Caglar-Gmail", encode
            MailAddress mailFrom = new MailAddress(mailAdress, mailAdressDiplayName, encode);
            Email.From = mailFrom;
            //Email.CC.Add("");//Emailini alan kişi liste içerisinde tanımlı olan kişi veya kişileri görebilir.
            //Email.Bcc.Add("");// bu alanda kişi eklenen kişileri göremez.
            Email.Subject = emailSubject;
            Email.Body = emailBody;
            Email.IsBodyHtml = true;
            if (!string.IsNullOrEmpty(dosyaYolu))
                Email.Attachments.Add(new Attachment(dosyaYolu));
            SmtpClient smtpMail = new SmtpClient("smtp.gmail.com", 587);
            smtpMail.Credentials = new System.Net.NetworkCredential(emailUsername, emailpassword);
            smtpMail.EnableSsl = true;
            smtpMail.Send(Email);
        }
    }
}
