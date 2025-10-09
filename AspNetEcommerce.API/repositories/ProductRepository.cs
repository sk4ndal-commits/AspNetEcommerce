using AspNetEcommerce.API.db;
using AspNetEcommerce.API.entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetEcommerce.API.repositories;

public class ProductRepository : IProductRepository
{
    private readonly EcommerceDbContext _dbContext;

    public ProductRepository(EcommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _dbContext.Products.ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(long id)
    {
        return await _dbContext.Products.FindAsync(id);
    }

    public async Task<Product?> GetByCategoryIdAsync(long categoryId)
    {
        return await _dbContext.Products
            .FirstOrDefaultAsync(p => p.CategoryId == categoryId);
    }

    public async Task<IEnumerable<Product>> GetByNameContainingAsync(
        string searchTerm)
    {
        return await _dbContext.Products
            .Where(p => p.Name.Contains(searchTerm))
            .ToListAsync();
    }
}