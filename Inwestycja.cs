using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FunduszModel
{
    [Table("Inwestycje")]
    public class Inwestycja
    {
        [Key]
        public int Id { get; set; }
        public string NrInwestycji { get; set; }
        public string PostFix { get; set; } //NrInwestycji+PostFix, np.: 1/INW/2019
    }
}
