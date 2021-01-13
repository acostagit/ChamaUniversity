using Chama.Core.DomainObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Professor.API.Data.Mapping
{
    public class ProfessorMapping : IEntityTypeConfiguration<Models.Professor>
    {
        public void Configure(EntityTypeBuilder<Models.Professor> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Sobrenome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            //builder.Property(c => c.)
            //    .IsRequired()
            //    .HasColumnType("varchar(100)");

            builder.Property(c => c.DataCadastro)
                .IsRequired()
                .HasColumnType("DateTime");

            builder.ToTable("Professor");
        }
    }
}
