using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailTest.AspNet
{
    public partial class EmailTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var mail = new MailMessage();

            mail.To.Add(new MailAddress(txtEmailTo.Text));
            mail.From = new MailAddress(txtEmailFrom.Text);

            mail.Subject = txtEmailSubject.Text;

            if (!String.IsNullOrWhiteSpace(txtEmailHtmlBody.Text))
            {
                mail.Body = txtEmailHtmlBody.Text;
                mail.IsBodyHtml = true;
            }
            else if (!String.IsNullOrWhiteSpace(txtEmailBody.Text))
            {
                mail.Body = txtEmailBody.Text;
                mail.IsBodyHtml = false;
            }

            if (mail.Body != string.Empty)
            {
                SmtpClient client = new SmtpClient(txtSMTPServer.Text);
                if (txtSMTPPort.Text != string.Empty)
                {
                    client.Port = Convert.ToInt16(txtSMTPPort.Text);
                }
                if (!String.IsNullOrWhiteSpace(txtSMTPUser.Text))
                {
                    if (!String.IsNullOrWhiteSpace(txtSMTPUser.Text))
                    {
                        client.Credentials = new System.Net.NetworkCredential(txtSMTPUser.Text, txtSMTPPassword.Text);
                    }
                }
                client.Send(mail);
                Response.Redirect("EmailSent.aspx");
            }

        }
    }
}