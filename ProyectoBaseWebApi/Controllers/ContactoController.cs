using ProyectoBaseDataAccess;
using ProyectoBaseDataAccess.Business;
using ProyectoBaseDataAccess.DataAccess;
using ProyectoBaseDataAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoBaseWebApi.Controllers
{
    public class ContactoController : ApiController
    {
        public IHttpActionResult Generate(MailViewModel mail)
        {
            string mailFrom = System.Configuration.ConfigurationManager.AppSettings["Mail.From"] != null ? System.Configuration.ConfigurationManager.AppSettings["Mail.From"].ToString() : "sao.arquitectura2017@gmail.com";
            string mailTo = System.Configuration.ConfigurationManager.AppSettings["Mail.To"] != null ? System.Configuration.ConfigurationManager.AppSettings["Mail.To"].ToString() : "mastronardi.romina@gmail.com";
            string body = mail.Comentario;
            string subject = "El usuario " + mail.Nombre + " envio una consulta";

            ContactoBusiness contactoBusiness = new ContactoBusiness();
            contactoBusiness.SendMail(subject, mailFrom, mailTo, body);

            return Ok(1);
        }
    }
}