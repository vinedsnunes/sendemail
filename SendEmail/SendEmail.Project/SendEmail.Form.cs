using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendEmail.Project
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            string destinatarioEmail = txt_destinatario.Text;
            string assunto = txt_assunto.Text;
            string remetenteEmail = "vinicius.dsnunes@gmail.com";
            string remetenteNome = "Vinícius Nunes";

            MailAddress from = new MailAddress(remetenteEmail, remetenteNome);
            MailAddress to = new MailAddress(destinatarioEmail);
            List<MailAddress> cc = new List<MailAddress>();
            cc.Add(new MailAddress("Someone@domain.topleveldomain", "Name and stuff"));
            EnviarEmail(assunto, from, to, cc);
        }
        protected void EnviarEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            string Text = txt_mensagem.Text;

            SmtpClient mailClient = new SmtpClient("smtp.gmail.com");
            mailClient.EnableSsl = true; // GMail requer SSL
            mailClient.Port = 587;       // porta para SSL
            mailClient.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
            mailClient.UseDefaultCredentials = false; // vamos utilizar credencias especificas

            // seu usuário e senha para autenticação
            mailClient.Credentials = new NetworkCredential("...@gmail.com", "senha");

            MailMessage msgMail;
            msgMail = new MailMessage();
            msgMail.From = _from;
            msgMail.To.Add(_to);
            foreach (MailAddress addr in _cc)
            {
                msgMail.CC.Add(addr);
            }
            if (_bcc != null)
            {
                foreach (MailAddress addr in _bcc)
                {
                    msgMail.Bcc.Add(addr);
                }
            }
            msgMail.Subject = _subject;
            msgMail.Body = Text;
            msgMail.IsBodyHtml = true;
            mailClient.Send(msgMail);
            msgMail.Dispose();
        }
    }
}
