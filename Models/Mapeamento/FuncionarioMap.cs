using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectServBeer.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectServBeer.Models.Mapeamento
{

    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.nome).HasMaxLength(35).IsRequired();
            builder.Property(p => p.senha).HasMaxLength(15).IsRequired();
            builder.Property(p => p.cpf).HasMaxLength(14).IsRequired();


            builder.HasMany(p => p.funcionarios).WithOne(p => p.funcionario).HasForeignKey(p => p.funcionarioID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Funcionario");
        }
    }
}
