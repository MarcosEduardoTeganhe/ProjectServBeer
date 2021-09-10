using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{

    [Table("Produto")]
    public class Produto
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do nome PRODUTO esta inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo nome PRODUTO é obrigatório")]
        [Display(Name = "Nome do Produto")]
        public int nome_prod { get; set; }

        [Display(Name = "Descrição do Produto")]
        public Categoria tipo_prod { get; set; }

        [Display(Name = "Nome do Fornecedor")]
        public Fornecedor fornecedor { get; set; }

        [Display(Name = "Quantidade")]
        [DisplayFormat(DataFormatString = "{0:F1}")]
        public int quantidade { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public int valor_prod { get; set; }
        public ICollection<ItensServicos> produtos { get; set; }
    }
}
