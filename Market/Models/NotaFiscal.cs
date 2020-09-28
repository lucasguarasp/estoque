using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class NotaFiscal
    {
        [Key]
        public int IdNotaFiscal { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        public DateTime DataInclusao { get; set; }
        public DateTime? DataExclusao { get; set; }
        [NotMapped]
        public IFormFile Arquivo { get; set; }


    }
}
