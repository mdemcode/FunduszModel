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
    public class Operacja
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TypOperacji Typ { get; set; }
        public string Opis { get; set; }
        public decimal Kwota { get; set; }
        public decimal SaldoFunduszuPoOperacji { get; set; }

        public enum TypOperacji
        {
            FunduszZalozycielski,
            SplataPozyczki,
            PrzychodZLokaty,
            PrzychodInny,

        };
    }
}
