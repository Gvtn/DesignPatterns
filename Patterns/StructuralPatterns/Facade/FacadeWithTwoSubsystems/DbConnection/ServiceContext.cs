using Microsoft.EntityFrameworkCore;

namespace StructuralPatterns.Facade.FacadeWithTwoSubsystems.DbConnection
{
    internal class ServiceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            optionsBuilder.UseSqlite($"Data Source={projectDirectory}/Users.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Login);
                entity.HasIndex(e => e.Mail)
                .IsUnique();
                entity.Property(e => e.OrdersCount)
                .HasDefaultValue(0);
            });
        }
        public virtual DbSet<User> Users { get; set; }
    }
}