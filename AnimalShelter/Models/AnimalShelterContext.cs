using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : IdentityDbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
    public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
			builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Scooter", Species = "Dog" },
              new Animal { AnimalId = 2, Name = "Jim", Species = "Cat" },
              new Animal { AnimalId = 3, Name = "Fluffy", Species = "Cat" },
              new Animal { AnimalId = 4, Name = "Boomer", Species = "Dog" },
              new Animal { AnimalId = 5, Name = "Dexter", Species = "Dog" }
          );
    }
  }
}