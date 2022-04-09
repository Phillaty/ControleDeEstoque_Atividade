using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace controlinhoDeEstoquinho
{
    [Table("produto", Schema = "public")]
    internal class DtoProduto
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public int quantidade { get; set; }
        public string marca { get; set; }
        public decimal preco { get; set; }

    }
}
