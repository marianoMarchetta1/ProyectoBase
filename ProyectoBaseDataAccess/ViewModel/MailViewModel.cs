using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoBaseDataAccess.ViewModel
{
    public class MailViewModel
    {
        public string Nombre { get; set; }
        public string Consulta { get; set; }

        public string Email { get; set; }
    }
}
