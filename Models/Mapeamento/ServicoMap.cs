using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectServBeer.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectServBeer.Models.Mapeamento
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.clienteID).IsRequired();
            builder.Property(p => p.valor).HasColumnType("float").IsRequired();
            builder.Property(p => p.valor_promocao).HasColumnType("float").IsRequired();
            builder.Property(p => p.funcionarioID).IsRequired();


            builder.HasMany(p => p.itensservicos).WithOne(p => p.servico).HasForeignKey(p => p.servicoID).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.servicorecebido).WithOne(p => p.servico).HasForeignKey(p => p.servicoID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Servico");
        }
    }
}
