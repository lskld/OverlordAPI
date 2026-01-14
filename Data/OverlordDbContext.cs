using Microsoft.EntityFrameworkCore;
using OverlordAPI.Models.Entities;

namespace OverlordAPI.Data
{
    public class OverlordDbContext : DbContext
    {
        public OverlordDbContext(DbContextOptions<OverlordDbContext> options) : base(options) { }

        public DbSet<Minion> Minions { get; set; }
        public DbSet<EvilLair> Lairs { get; set; }
        public DbSet<Mission> Missions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //MINIONS: 
            modelBuilder.Entity<Minion>()  
                .Property(m => m.Type)
                .HasConversion<string>();

            modelBuilder.Entity<Minion>()
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Minion>()
                .Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}
