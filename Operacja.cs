using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunduszModel
{
    [Table ("Operacje")]
    class Operacja
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataOperacji { get; set; }

    }
}
