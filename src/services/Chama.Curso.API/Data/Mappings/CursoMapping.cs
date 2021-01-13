using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Curso.API.Data.Mappings
{
    public class CursoMapping : IEntityTypeConfiguration<Models.Curso>
    {
        public void Configure(EntityTypeBuilder<Models.Curso> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Preco)
                .IsRequired()
                .HasColumnType("decimal(5,2)");

            builder.Property(c => c.DataCadastro)
                .IsRequired()
                .HasColumnType("DateTime");

            builder.ToTable("Cursos");
        }
    }
}
