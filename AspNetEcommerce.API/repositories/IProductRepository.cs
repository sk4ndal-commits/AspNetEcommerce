using AspNetEcommerce.API.dto;
using AspNetEcommerce.API.entities;

namespace AspNetEcommerce.API.repositories;

/// <summary>
/// Defines operations for retrieving and managing product data in the repository.
/// </summary>
public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync(PageRequest pageRequest);
    Task<int> CountAllAsync();
    Task<Product?> GetByIdAsync(long id);

    Task<IEnumerable<Product>> GetByCategoryIdAsync(long categoryId,
        PageRequest pageRequest);
    Task<int> CountByCategoryIdAsync(long categoryId);

    Task<IEnumerable<Product>> GetByNameContainingAsync(string searchTerm,
        PageRequest pageRequest);
    Task<int> CountByNameContainingAsync(string searchTerm);
}