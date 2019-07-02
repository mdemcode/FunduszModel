﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunduszModel
{
    [Table("Uczestnicy")]
    public class Uczestnik
    {
        [Key]
        public int Id { get; set; }
        public string ImieNazwisko { get; set; }
        public DateTime DataPrzystapienia { get; set; }
        public decimal Wklad { get; set; }
        public decimal Udzial { get; set; }
        public string EmailTelefon { get; set; }
    }
}
