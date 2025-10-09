using AspNetEcommerce.API.entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetEcommerce.API.db;

public class EcommerceDbContext : DbContext
{
    public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) :
        base(options){}
    
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
}