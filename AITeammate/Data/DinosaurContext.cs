using Microsoft.EntityFrameworkCore;
using AITeammate.Models;

namespace AITeammate.Data;

public class DinosaurContext : DbContext
{
    public DinosaurContext(DbContextOptions<DinosaurContext> options)
        : base(options)
    {
    }

    public DbSet<Dinosaur> Dinosaurs { get; set; } = null!;
    public DbSet<Skin> Skins { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dinosaur>().ToTable("Dinosaur");
        modelBuilder.Entity<Skin>().ToTable("Skin");
    }
}
