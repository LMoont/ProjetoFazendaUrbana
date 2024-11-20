using FazendaUrbanaAPI.Data.Map;
using FazendaUrbanaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FazendaUrbanaAPI.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options)
            : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }
    }


}
