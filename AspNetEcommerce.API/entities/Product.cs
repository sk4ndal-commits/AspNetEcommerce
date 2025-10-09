using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetEcommerce.API.entities;

[Table("products")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public long Id { get; set; }
    
    [ForeignKey("CategoryId")]
    [Column("category_id")]
    public long CategoryId { get; set; }
    
    public ProductCategory Category { get; set; }
    
    [Column("sku")]
    public string Sku { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("description")]
    public string Description { get; set; }
    
    [Column("unit_price")]
    public decimal UnitPrice { get; set; }
    
    [Column("image_url")]
    public string ImageUrl { get; set; }
    
    [Column("active")]
    public bool Active { get; set; }
    
    [Column("units_in_stock")]
    public int UnitsInStock { get; set; }
    
    [Column("date_created")]
    public DateTime DateCreated { get; set; }
    
    [Column("last_updated")]
    public DateTime LastUpdated { get; set; }
}