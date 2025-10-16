using AspNetEcommerce.API.dto;
using AspNetEcommerce.API.entities;

namespace AspNetEcommerce.API.services;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllAsync(PageRequest pageRequest);
    Task<Product?> GetByIdAsync(long id);

    Task<IEnumerable<Product>> GetByCategoryIdAsync(long categoryId,
        PageRequest pageRequest);

    Task<IEnumerable<Product>> GetByNameContainingAsync(string searchTerm,
        PageRequest pageRequest);
}