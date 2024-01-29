using BlogEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogEF.Data.Mappings;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        //Tabela
        builder.ToTable("User");

        //Chave Primária
        builder.HasKey(x=>x.Id);

        //Identity
        builder.Property(x=>x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(x=>x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);
        
        // Propriedades
        builder.Property(x=>x.Bio);
        builder.Property(x=>x.Email);
        builder.Property(x=>x.Image);
        builder.Property(x=>x.PasswordHash);

        builder.Property(x=>x.Slug)
            .IsRequired()
            .HasColumnName("Slug")
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        //Índice
        builder.HasIndex(x=>x.Slug, "IX_User_Slug")
            .IsUnique();

        // Mapeamento muitos pra muitos
        builder.HasMany(x=>x.Roles)
            .WithMany(x=>x.Users)
            .UsingEntity<Dictionary<string, object>>(
                "UserRole",
                role => role
                    .HasOne<Role>()
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .HasConstraintName("FK_UserRole_RoleId")
                    .OnDelete(DeleteBehavior.Cascade),
                user => user
                    .HasOne<User>()
                    .WithMany()
                    .HasForeignKey("UserId")
                    .HasConstraintName("FK_UserRole_UserId")
                    .OnDelete(DeleteBehavior.Cascade)
            );
    }
}