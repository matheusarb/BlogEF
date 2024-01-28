using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEF.Models;

[Table("Category")]
public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MinLength(1)]
    [MaxLength(80)]
    [Column("Name", TypeName = "NVARCHAR")]
    public string Name { get; set; }
    
    [Required]
    [MinLength(1)]
    [MaxLength(80)]
    [Column("Slug", TypeName = "VARCHAR")]
    public string Slug { get; set; }
}