using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    public class Fornecedor
    {
        public int id { get; set; }
        public string empresa { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public ICollection<Pagamento> fornecedores { get; set; }
        public ICollection<Produto> fornecedor { get; set; }
    }
}
