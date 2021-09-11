using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectServBeer.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Mapeamento
{
    public class ItensServicosMap : IEntityTypeConfiguration<ItensServicos>
    {
        public void Configure(EntityTypeBuilder<ItensServicos> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.quantidade).HasColumnType("Int").IsRequired();
            builder.Property(p => p.valor).HasColumnType("float").IsRequired();
            builder.Property(p => p.produtoID).IsRequired();
            builder.Property(p => p.servicoID).IsRequired();

            builder.ToTable("ItemServicos");
        }
    }
}

