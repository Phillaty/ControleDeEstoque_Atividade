using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlinhoDeEstoquinho
{
    internal class context : DbContext
    {
        public context() : base("DB")
        {

        }

        public DbSet<DtoUsuario> usuario { get; set; }

        public DbSet<DtoProduto> produto { get; set; }

        public DbSet<DtoVenda> venda { get; set; }
    }
}
