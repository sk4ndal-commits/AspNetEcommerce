using AspNetEcommerce.API.entities;

namespace AspNetEcommerce.API.repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(long id);
    Task<Product?> GetByCategoryIdAsync(long categoryId);
    Task<IEnumerable<Product>> GetByNameContainingAsync(string searchTerm);
}