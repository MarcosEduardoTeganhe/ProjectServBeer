using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    public class Funcionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string cpf { get; set; }
        public ICollection<Servico> funcionarios { get; set; }
    }
}
