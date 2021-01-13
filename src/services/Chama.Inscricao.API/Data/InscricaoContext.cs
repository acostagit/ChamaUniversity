using Chama.Core.Data;
using Chama.Professor.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Inscricao.API.Data
{
    public class InscricaoContext : DbContext, IUnitOfWork
    {
        public InscricaoContext(DbContextOptions<InscricaoContext> options)
            : base(options) { }

        public DbSet<Models.Inscricao> Inscricoes{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InscricaoContext).Assembly);
        }

        public async  Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
