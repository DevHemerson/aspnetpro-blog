using AspNetPro.Blog.Models.entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetPro.Blog.Infrastructure.Data;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> dbContextOptions) 
        : base(dbContextOptions)
    {
    }

    public DbSet<Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assemby = typeof(BlogContext).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assemby);

        base.OnModelCreating(modelBuilder);
    }
}
