using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using smtpServer.Models;
using System.Net.Configuration;
namespace smtpServer.Controllers
{
    public class SetupController : Controller
    {
        // GET: Setup
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(smtpServer.Models.mail model)
        {
            try

            {
                MailMessage obj = new MailMessage(model.From, model.To);
               
                obj.Subject = model.Subject;
                obj.Body = model.Body;
                obj.IsBodyHtml = false;



                SmtpClient smtp = new SmtpClient();

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                smtp.EnableSsl = true;


                NetworkCredential nc = new NetworkCredential("shaantanupatil999@gmail.com", "dcxxycauxituqcep");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = nc;
                smtp.Send(obj);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return View();

        }
    }
}