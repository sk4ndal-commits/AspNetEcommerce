using AspNetEcommerce.API.db;
using AspNetEcommerce.API.dto;
using AspNetEcommerce.API.entities;
using AspNetEcommerce.API.utils;
using Microsoft.EntityFrameworkCore;

namespace AspNetEcommerce.API.repositories;

/// <inheritdoc cref="IProductRepository"/>
public class ProductRepository : IProductRepository
{
    private readonly EcommerceDbContext _dbContext;

    public ProductRepository(EcommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Product>> GetAllAsync(PageRequest pageRequest)
    {
        return await _dbContext.Products
            .ApplyPagination(pageRequest)
            .ToListAsync();
    }

    public async Task<int> CountAllAsync()
    {
        return await _dbContext.Products.CountAsync();
    }

    public async Task<Product?> GetByIdAsync(long id)
    {
        return await _dbContext.Products.FindAsync(id);
    }

    public async Task<IEnumerable<Product>> GetByCategoryIdAsync(
        long categoryId, PageRequest pageRequest)
    {
        return await _dbContext.Products
            .Where(p => p.CategoryId == categoryId)
            .ApplyPagination(pageRequest)
            .ToListAsync();
    }

    public async Task<int> CountByCategoryIdAsync(long categoryId)
    {
        return await _dbContext.Products
            .Where(p => p.CategoryId == categoryId)
            .CountAsync();
    }

    public async Task<IEnumerable<Product>> GetByNameContainingAsync(
        string searchTerm, PageRequest pageRequest)
    {
        return await _dbContext.Products
            .Where(p => p.Name.Contains(searchTerm))
            .ApplyPagination(pageRequest)
            .ToListAsync();
    }

    public async Task<int> CountByNameContainingAsync(string searchTerm)
    {
        return await _dbContext.Products
            .Where(p => p.Name.Contains(searchTerm))
            .CountAsync();
    }
}