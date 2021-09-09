using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    public class Produto
    {
        public int id { get; set; }
        public int nome_prod { get; set; }
        public Categoria tipo_prod { get; set; }
        public Fornecedor fornecedor { get; set; }
        public int quantidade { get; set; }
        public int valor_prod { get; set; }
        public ICollection<ItensServicos> produtos { get; set; }
    }
}
