using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    internal class context : DbContext
    {
        public context() : base("ba")
        {
            
        }

        public DbSet<DtoUsuario> usuarios { get; set; }
    }
}
