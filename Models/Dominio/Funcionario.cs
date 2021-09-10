using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do nome CLIENTE esta inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo nome CLIENTE é obrigatório")]
        [Display(Name = "Nome do Cliente")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Senha requerida")]
        [StringLength(20, ErrorMessage = "Deve ter entre 5 e 20 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string senha { get; set; }

        [Display(Name = "CPF")]
        [StringLength(14, ErrorMessage = "Não aceita CPF com mais de 14 dígitos")]
        [Remote("ValidarCPF", "Clientes", ErrorMessage = "CPF Inválido!!!")]
        public string cpf { get; set; }
        public ICollection<Servico> funcionarios { get; set; }
    }
}
