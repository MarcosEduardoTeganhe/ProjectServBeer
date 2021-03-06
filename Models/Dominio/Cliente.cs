using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do nome CLIENTE esta inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo nome CLIENTE é obrigatório")]
        [Display(Name = "Nome do Cliente")]
        public string nome_cliente { get; set; }

        [Display(Name = "CPF")]
        [StringLength(14, ErrorMessage = "Não aceita CPF com mais de 14 dígitos")]
        public string cpf { get; set; }

        [Display(Name = "Telefone")]
        [StringLength(15, ErrorMessage = "Telefone maior que 15 caracteres")]
        [Required(ErrorMessage = "Campo Telefone é obrigatório")]
        public string telefone { get; set; }
        public ICollection<Servico> clientes { get; set; }
    }
}
