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

        // Propriedades
        builder.Property(x=>x.Title)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(160);
        
        builder.Property(x=>x.LastUpdateDate)
            .IsRequired()
            .HasColumnName("LastUpdateDate")
            .HasColumnType("SMALLDATETIME")
            .HasDefaultValue(DateTime.Now.ToUniversalTime());
            // .HasDefaultValueSql("GETDATE()") 
    }
}