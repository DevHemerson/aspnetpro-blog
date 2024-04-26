using AspNetPro.Blog.Models.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetPro.Blog.Infrastructure.Data.Mapping;

public class PostMap : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable("Post");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .HasMaxLength(70)
            .IsRequired();
        builder.Property(x => x.Summary) 
            .HasMaxLength(500)
            .IsRequired();
        builder.Property(x => x.Content)
            .HasColumnType("NVARCHAR(MAX)");
    }
}
