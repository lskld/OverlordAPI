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
            //Minions: 
            modelBuilder.Entity<Minion>()
                .Property(m => m.Type)
                .HasConversion<string>()
                .HasMaxLength(100);

            modelBuilder.Entity<Minion>()
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Minion>()
                .Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(500);

            //Evil Lairs:
            modelBuilder.Entity<EvilLair>()
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<EvilLair>()
                .Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(100);

            //Missions:
            modelBuilder.Entity<Mission>()
                .Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
