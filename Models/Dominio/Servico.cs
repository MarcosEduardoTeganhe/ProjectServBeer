using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    public class Servico
    {
        public int id { get; set; }
        public string nome { get; set; }
        public float valor { get; set; }
        public float valor_promocao { get; set; }
        public Funcionario funcionario { get; set; }
        public Cliente cliente { get; set; }
        public ICollection<Recebimento> servicos { get; set; }
    }
}
