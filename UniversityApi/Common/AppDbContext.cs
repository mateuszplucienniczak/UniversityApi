using Microsoft.EntityFrameworkCore;
using UniversityApi.UsersModule.Domain;

namespace UniversityApi.Common;

public sealed class AppDbContext : DbContext
{
    public required DbSet<User> Users { get; init; }

    public AppDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseInMemoryDatabase("app");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .Property(u => u.Username)
            .HasMaxLength(20);

        modelBuilder.Entity<User>()
            .Property(u => u.Email)
            .HasMaxLength(20);

        modelBuilder.Entity<User>()
            .Property(u => u.Password)
            .HasMaxLength(20);

        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 1,
                Username = "user1",
                Email = "user1@gmail.com",
                Password = "user1"
            },
            new User
            {
                UserId = 2,
                Username = "user2",
                Email = "user2@gmail.com",
                Password = "user2"
            },
            new User
            {
                UserId = 3,
                Username = "admin1",
                Email = "admin1@gmail.com",
                Password = "admin"
            });
    }
}