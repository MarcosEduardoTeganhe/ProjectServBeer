using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectServBeer.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Mapeamento
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.descricao).HasMaxLength(15).IsRequired();

            builder.HasMany(p => p.categorias).WithOne(p => p.tipo_prod).HasForeignKey(p => p.categoriaID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Categoria");
        }
    }
}
