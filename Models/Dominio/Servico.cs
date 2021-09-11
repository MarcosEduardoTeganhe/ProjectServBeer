using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    [Table("Servico")]
    public class Servico
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do nome CLIENTE esta inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo nome CLIENTE é obrigatório")]
        [Display(Name = "Nome do Cliente")]
        public Cliente cliente { get; set; }
        public int clienteID { get; set; }


        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public float valor { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public float valor_promocao { get; set; }

        [Display(Name = "Funcionario")]
        public Funcionario funcionario { get; set; }
        public int funcionarioID { get; set; }

        public ICollection<ItensServicos> itensservicos { get; set; }
        public ICollection<Recebimento> servicorecebido { get; set; }
       
    }
}
