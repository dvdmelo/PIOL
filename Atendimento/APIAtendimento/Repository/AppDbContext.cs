using Microsoft.EntityFrameworkCore;

namespace Metro.Atendimento.Portal.Repository
{
    public class AppDbContext: DbContext
    {
    
        public DbSet<Models.Atendimento> Atendimentos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Atendimento>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "DbAtendimento");
        }
    }
}
