using APIAtendimento.Models;
using Microsoft.EntityFrameworkCore;

namespace APIAtendimento.Repository
{
    public class AppDbContext: DbContext
    {
    
        public DbSet<Atendimento> Atendimentos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atendimento>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "DbAtendimento");
        }
    }
}
