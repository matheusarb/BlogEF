using System.Security.Cryptography.X509Certificates;
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
        builder.Property(x=>x.CreateDate)
            .IsRequired()
            .HasColumnName("CreateDate")
            .HasColumnType("DATETIME");
            // .HasDefaultValue(DateTime.Now.ToUniversalTime());
        builder.Property(x=>x.LastUpdateDate)
            .IsRequired()
            .HasColumnName("LastUpdateDate")
            .HasColumnType("DATETIME")
            .HasDefaultValue(DateTime.Now.Date);
            // .HasDefaultValueSql("GETDATE()");
        
        // Relacionamento UM para muitos
            //Autor
            builder.HasOne(x=>x.Author)
                .WithMany(x=>x.Posts)
                .HasConstraintName("FK_Post_Author")
                .OnDelete(DeleteBehavior.Cascade);

            //Categoria
            builder.HasOne(x=>x.Category)
                .WithMany(x=>x.Posts)
                .HasConstraintName("FK_Category_Post")
                .OnDelete(DeleteBehavior.Cascade);

        // Relacionamento MUITOS PARA MUITOS
            builder.HasMany(x=>x.Tags)
                .WithMany(x=>x.Posts)
                .UsingEntity<Dictionary<string, object>>(
                    "PostTag",
                     post => post.HasOne<Tag>()
                        .WithMany()
                        .HasForeignKey("PostId")
                        .HasConstraintName("FK_PostTag_PostId")
                        .OnDelete(DeleteBehavior.Cascade),
                    tag => tag.HasOne<Post>()
                        .WithMany()
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK_PostTag_TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                );
    }
}