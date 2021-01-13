using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chama.Aluno.API.Data
{
    public class AlunosContext : DbContext, IUnitOfWork
    {
        public AlunosContext(DbContextOptions<AlunosContext> options)
           : base(options) { }

        public DbSet<Models.Aluno> Alunos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlunosContext).Assembly);
        }

        public void ChangeDatabase(string database)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSqlCommand(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FromSql<TEntity>(string sql, params object[] parameters) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IRepository<TEntity> GetRepository<TEntity>(bool hasCustomRepository = false) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(bool ensureAutoHistory = false)
        {
            throw new NotImplementedException();
        }

        public void TrackGraph(object rootEntity, Action<EntityEntryGraphNode> callback)
        {
            throw new NotImplementedException();
        }
    }
}
