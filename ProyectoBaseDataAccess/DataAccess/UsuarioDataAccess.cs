using ProyectoBaseDataAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDataAccess.DataAccess
{
    public class UsuarioDataAccess
    {
        public List<UsuarioViewModel> GetList()
        {
            using (Entities entities = new Entities())
            {
                List<UsuarioViewModel> usvm = entities.USUARIO.Select(x=> new UsuarioViewModel() {
                                                    Id = x.Id,
                                                    Nombre = x.Nombre
                                                }).ToList();

                return usvm;
            }
        }

        public UsuarioViewModel GetUserById(int id)
        {
            using (Entities entities = new Entities())
            {
                UsuarioViewModel usvm = entities.USUARIO
                    .Select(x => new UsuarioViewModel()
                    {
                        Id = x.Id,
                        Nombre = x.Nombre
                    }).Where(x=> x.Id == id).FirstOrDefault();

                return usvm;
            }
        }
    }
}
