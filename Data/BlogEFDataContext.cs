using BlogEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEF.Data;

public class BlogEFDataContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=BlogEF;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");

}