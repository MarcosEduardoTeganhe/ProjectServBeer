using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectServBeer.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Mapeamento
{
    public class RecebimentoMap : IEntityTypeConfiguration<Recebimento>
    {
        public void Configure(EntityTypeBuilder<Recebimento> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.servicoID).IsRequired();
            builder.Property(p => p.valor).HasColumnType("float").IsRequired();
            builder.Property(p => p.data_recebimento).HasColumnType("Date").IsRequired();

            builder.ToTable("Recebimento");
        }
    }
}
   
