using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    public class Pagamento
    {
        public int id { get; set; }
        public Fornecedor fornecedor { get; set; }
        public DateTime dataEmissao { get; set; }
        public DateTime dataVencimento { get; set; }
        public float valor { get; set; }
    }
}
