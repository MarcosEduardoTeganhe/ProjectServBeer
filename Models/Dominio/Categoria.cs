using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Dominio
{
    public class Categoria
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public ICollection<Produto> categorias { get; set; }
    }
}
