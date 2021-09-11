using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectServBeer.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Mapeamento
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.nome_cliente).HasMaxLength(35).IsRequired();
            builder.Property(p => p.cpf).HasMaxLength(14).IsRequired();
            builder.HasIndex(p => p.cpf).IsUnique();
            builder.Property(p => p.telefone).HasMaxLength(15).IsRequired();


            builder.HasMany(p => p.clientes).WithOne(p => p.cliente).HasForeignKey(p => p.clienteID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Cliente");
        }
    }
}
