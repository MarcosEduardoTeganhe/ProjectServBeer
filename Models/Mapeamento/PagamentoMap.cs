using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectServBeer.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Mapeamento
{
    public class PagamentoMap : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.fornecedorID).IsRequired();
            builder.Property(p => p.dataEmissao).HasColumnType("Date").IsRequired();
            builder.Property(p => p.dataVencimento).HasColumnType("Date").IsRequired();
            builder.Property(p => p.valor).HasColumnType("float").IsRequired();

            builder.ToTable("Pagamento");
        }
    }
}
