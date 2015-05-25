using EmailTest.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace EmailTest.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmailVM email = new EmailVM();
            return View(email);
        }

        [HttpPost]
        public ActionResult Index(EmailVM email)
        {
            if (ModelState.IsValid)
            {
                var mail = new MailMessage();

                mail.To.Add(new MailAddress(email.Email_To));
                mail.From = new MailAddress(email.Email_From);

                mail.Subject = email.Email_Subject;

                if (!String.IsNullOrWhiteSpace(email.Email_HtmlBody))
                {
                    mail.Body = email.Email_HtmlBody;
                    mail.IsBodyHtml = true;
                }
                else if (!String.IsNullOrWhiteSpace(email.Email_Body))
                {
                    mail.Body = email.Email_Body;
                    mail.IsBodyHtml = false;
                }
                else
                {
                    ModelState.AddModelError("Email_Body", "You must enter either a body or html body");
                    return View(email);
                }

                SmtpClient client = new SmtpClient(email.Smtp_Server);
                if (email.Smtp_Port.HasValue)
                {
                    client.Port = email.Smtp_Port.Value;
                }
                if (!String.IsNullOrWhiteSpace(email.Smtp_User))
                {
                    if (!String.IsNullOrWhiteSpace(email.Smtp_Pwd))
                    {
                        client.Credentials = new System.Net.NetworkCredential(email.Smtp_User, email.Smtp_Pwd);
                    }
                    else
                    {
                        ModelState.AddModelError("Smtp_Pwd", "If you enter a user name you must enter a password");
                        return View(email);
                    }                    
                }
                client.Send(mail);
                return RedirectToAction("EmailSent");

            }
            else
            {
                return View(email);
            }                       
        }

        public ActionResult EmailSent()
        {
            return View();
        }

    }
}