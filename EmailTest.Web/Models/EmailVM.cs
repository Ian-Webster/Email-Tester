using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmailTest.Web.Models
{
    public class EmailVM
    {
        [Required]
        public string Email_To { get; set; }
        [Required]
        public string Email_From { get; set; }
        [Required]
        public string Email_Subject { get; set; }

        [UIHint("MultilineText")]
        public string Email_Body { get; set; }
        [UIHint("MultilineText")]
        [AllowHtml]
        public string Email_HtmlBody { get; set; }

        [Required]
        public string Smtp_Server { get; set; }
        public int? Smtp_Port { get; set; }
        public string Smtp_User { get; set; }
        public string Smtp_Pwd { get; set; }
        [Required]
        public bool UseSSL { get; set; }
    }
}