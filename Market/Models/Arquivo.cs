using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Arquivo
    {
        [Key]
        public int IdArquivo { get; set; }
        public string Caminho { get; set; }

        [Required]
        public DateTime DataInclusao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public virtual NotaFiscal NotaFiscal { get; set; }

    }
}
