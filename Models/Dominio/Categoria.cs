using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{

    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho de nome descricao inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo descricao é obrigatório")]
        [Display(Name = "descricao")]
        public string descricao { get; set; }

        public ICollection<Produto> categorias { get; set; }
    } 
}
