using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    [Table("Pagamento")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Fornecedor")]
        public Fornecedor fornecedor { get; set; }
        public int fornecedorID { get; set; }

        [Display(Name = "Data de Emissao")]
        public DateTime dataEmissao { get; set; }

        [Display(Name = "Data de Vencimento")]
        public DateTime dataVencimento { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public float valor { get; set; }
    }
}
