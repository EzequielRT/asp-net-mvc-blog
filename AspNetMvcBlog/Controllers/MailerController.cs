using ActionMailer.Net.Mvc;
using AspNetMvcBlog.Models.FormModel;
using System;

namespace AspNetMvcBlog.Controllers
{
    public class MailerController : MailerBase
    {
        public EmailResult Contact(ContactFormModel model)
        {
            From = String.Format("{0} <{1}>", model.Name, model.Email);
            // From = "Ezequiel Rodrigues <ezefuts@gmail.com>";
            To.Add("ezefuts@gmail.com");
            Subject = "Contato pelo blog";

            return Email("Contact", model);
        }
    }
}