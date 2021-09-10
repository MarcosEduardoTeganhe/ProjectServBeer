using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace ProjectServBeer.Models.Dominio
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho nome EMPRESA esta inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo nome EMPRESA é obrigatório")]
        [Display(Name = "Nome da Empresa")]
        public string empresa { get; set; }

        [Display(Name = "CNPJ")]
        [StringLength(14, ErrorMessage = "Não aceita CNPJ com mais de 14 dígitos")]
        [Remote("ValidarCNPJ", "Clientes", ErrorMessage = "CNPJ Inválido!!!")]
        public string cnpj { get; set; }

        [Display(Name = "Telefone")]
        [StringLength(15, ErrorMessage = "Telefone maior que 15 caracteres")]
        [RegularExpression("^/([1-9]{2}/) (?:[2-8]|9[1-9])[0-9]{3}/-[0-9]{4}$", ErrorMessage = "Telefone invalido")]
        public string telefone { get; set; }

        [Display(Name = "E-Mail")]
        [StringLength(35, ErrorMessage = "E-Mail maior que 35 caracteres")]
        [RegularExpression("^[a-zA-Z0-9_+-]+[a-zA-Z0-9._+-]*[a-zA-Z0-9_+-]+@[a-zA-Z0-9_+-]+[a-zA-Z0-9._+-]*[.]{1,1}[a-zA-Z]{2,}$", ErrorMessage = "Email invalido")]
        public string email { get; set; }
        public ICollection<Pagamento> fornecedores { get; set; }
        public ICollection<Produto> fornecedor { get; set; }
    }
}
