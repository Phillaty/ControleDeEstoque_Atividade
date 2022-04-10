using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    public class Model
    {
        internal void setUsuario(DtoUsuario u)
        {
            context db = new context();
            db.usuarios.Add(u);
            db.SaveChanges();
        }

        //public List<DtoUsuario2> GetUsuarios()
        //{
        //    context db = new context();
        //    List<DtoUsuario2> usuarios = (from u in db.Usuarios select new DtoUsuario2
        //    {
        //        Id = u.Id,
        //        Name = u.Name
        //    }).ToList();
        //}

    }
}
