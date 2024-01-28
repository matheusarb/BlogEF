using BlogEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogEF.Data.Mappings;

public class PostMap : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        // Tabela
        builder.ToTable("Post");

        //Primary key
        builder.HasKey(x=>x.Id);

        //Identity
        builder.Property(x=>x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
    }
}