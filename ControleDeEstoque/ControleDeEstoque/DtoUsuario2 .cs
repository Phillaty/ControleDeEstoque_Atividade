﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoque
{
    [Table("usuario", Schema = "public")]
    internal class DtoUsuario2
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
