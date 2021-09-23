using EFCodeFirst.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EFCodeFirst.DAL
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EFConnectionstring") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Universidade> Universidades { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Notas> Notas { get; set; }
    }
}