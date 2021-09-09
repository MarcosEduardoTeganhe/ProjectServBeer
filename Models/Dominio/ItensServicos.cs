using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    public class ItensServicos
    {
        public int id { get; set; }
        public int quantidade { get; set; }
        public float valor { get; set; }
        public Produto produto { get; set; }
        public Servico servico { get; set; }
    }
}
