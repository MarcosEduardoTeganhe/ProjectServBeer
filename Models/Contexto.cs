using Microsoft.EntityFrameworkCore;
using ProjectServBeer.Models.Dominio;

namespace ProjectServBeer.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ItensServicos> ItensVendas { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Recebimento> Recebimentos { get; set; }
    }
}
