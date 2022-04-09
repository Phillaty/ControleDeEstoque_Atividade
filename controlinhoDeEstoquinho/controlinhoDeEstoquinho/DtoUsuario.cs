using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace controlinhoDeEstoquinho
{
    [Table("usuario", Schema = "public")]
    internal class DtoUsuario
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
    }
}
