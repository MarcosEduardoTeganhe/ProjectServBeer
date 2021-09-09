using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    public class Recebimento
    {
        public int id { get; set; }
        public Servico servico { get; set; }
        public float valor { get; set; }
        public DateTime data_recebimento { get; set; }
    }
}
