using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectServBeer.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Mapeamento
{

    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.empresa).HasMaxLength(35).IsRequired();
            builder.Property(p => p.cnpj).HasMaxLength(18).IsRequired();
            builder.Property(p => p.telefone).HasMaxLength(15).IsRequired();
            builder.Property(p => p.email).HasMaxLength(35);

            builder.HasMany(p => p.fornecedores).WithOne(p => p.fornecedor).HasForeignKey(p => p.fornecedorID).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.fornecedor).WithOne(p => p.fornecedor).HasForeignKey(p => p.fornecedorID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Fornecedor");
        }
    }
}
