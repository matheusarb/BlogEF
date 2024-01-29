using BlogEF.Data.Mappings;
using BlogEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEF.Data;

public class BlogEFDataContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=BlogEFFluentMapping;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");
            // optionsBuilder.LogTo(Console.WriteLine); //Logar informações
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryMap());
        modelBuilder.ApplyConfiguration(new PostMap());
        modelBuilder.ApplyConfiguration(new UserMap());
    }
}