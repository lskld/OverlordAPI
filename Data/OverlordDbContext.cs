using Microsoft.EntityFrameworkCore;
using OverlordAPI.Enums;
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

            //Seed Data:
            modelBuilder.Entity<EvilLair>().HasData(
                new EvilLair { Id = 1, Name = "Volcano Island", Location = "Pacific Ocean" },
                new EvilLair { Id = 2, Name = "The Moon Base", Location = "Low Earth Orbit" },
                new EvilLair { Id = 3, Name = "Deep Sea Trench", Location = "Mariana Trench" }
            );
            modelBuilder.Entity<Mission>().HasData(
                new Mission { Id = 1, Title = "Steal the Moon", Difficulty = 10 },
                new Mission { Id = 2, Title = "Rig the Local Bingo", Difficulty = 1 },
                new Mission { Id = 3, Title = "Replace Clouds with Cotton Candy", Difficulty = 5 }
            );
            modelBuilder.Entity<Minion>().HasData(
                new Minion { Id = 1, Name = "Kevin", Type = MinionType.Scientist, EvilLevel = 8, EvilLairId = 1 },
                new Minion { Id = 2, Name = "Bob", Type = MinionType.Soldier, EvilLevel = 3, EvilLairId = 1 },
                new Minion { Id = 3, Name = "Dave", Type = MinionType.Infiltrator, EvilLevel = 6, EvilLairId = 2 },
                new Minion { Id = 4, Name = "Stuart", Type = MinionType.Janitor, EvilLevel = 1, EvilLairId = 3 },
                new Minion { Id = 5, Name = "Scarlett", Type = MinionType.Mystic, EvilLevel = 9, EvilLairId = 2 }
            );
        }
    }
}
