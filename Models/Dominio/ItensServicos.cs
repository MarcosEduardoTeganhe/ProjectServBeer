using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    [Table("ItensServicos")]
    public class ItensServicos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Quantidade")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public int quantidade { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public float valor { get; set; }

        [Display(Name = "Produto")]
        public Produto produto { get; set; }
        public int produtoID { get; set; }

        [Display(Name = "Servico")]
        public Servico servico { get; set; }
        public int servicoID { get; set; }
    }
}
