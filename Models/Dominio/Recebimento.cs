using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{

    [Table("Recebimento")]
    public class Recebimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Serviço")]
        public Servico servico { get; set; }
        public int servicoID { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public float valor { get; set; }

        [Display(Name = "Data de recebimento")]
        public DateTime data_recebimento { get; set; }
    }
}
