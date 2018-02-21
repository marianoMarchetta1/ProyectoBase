using ProyectoBaseDataAccess;
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
    public class UsuarioController : ApiController
    {
        // GET api/values
        //[Authorize]
        public List<UsuarioViewModel> Get()
        {
            //return new string[] { "Ovo", "God" };
            UsuarioDataAccess usuarioDataAccess = new UsuarioDataAccess();
            return usuarioDataAccess.GetList();
        }

        // GET api/values/5
        public UsuarioViewModel Get(int id)
        {
            UsuarioDataAccess usuarioDataAccess = new UsuarioDataAccess();
            return usuarioDataAccess.GetUserById(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
