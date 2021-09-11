using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectServBeer.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Mapeamento
{

    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.nome_prod).IsRequired();
            builder.Property(p => p.categoriaID).IsRequired();
            builder.Property(p => p.fornecedorID).IsRequired();
            builder.Property(p => p.valor_prod).HasColumnType("float").IsRequired();
            builder.Property(p => p.quantidade).HasColumnType("Int").IsRequired();

            builder.HasMany(p => p.produtos).WithOne(p => p.produto).HasForeignKey(p => p.produtoID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Produto");
        }
    }
}


