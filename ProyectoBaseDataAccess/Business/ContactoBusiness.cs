using ProyectoBaseDataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDataAccess.Business
{
    public class ContactoBusiness
    {
        public void SendMail(string subject, string mailFrom, string mailTo, string body)
        {
            using (var context = new Entities())
            {
                ContactoDataAccess contactoDataAccess = new ContactoDataAccess(context);
                contactoDataAccess.SendMail(subject, mailFrom, mailTo, body);
            }
        }
    }
}
