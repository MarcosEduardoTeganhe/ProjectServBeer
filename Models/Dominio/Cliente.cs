using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome_cliente { get; set; }
        public string cpf { get; set; }
        public int telefone { get; set; }
        public ICollection<Servico> clientes { get; set; }
    }
}
