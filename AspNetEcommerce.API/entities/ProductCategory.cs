using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetEcommerce.API.entities;

[Table("product_categories")]
public class ProductCategory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public long Id { get; set; }
    
    [Column("category_name")]
    public string CategoryName { get; set; }

    [InverseProperty("Category")]
    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
}