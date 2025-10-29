using AspNetEcommerce.API.dto;
using AspNetEcommerce.API.entities;

namespace AspNetEcommerce.API.services;

/// <summary>
/// Defines contract for product-related operations.
/// </summary>
public interface IProductService
{
    Task<PageResponse<Product>> GetAllAsync(PageRequest pageRequest);
    Task<Product?> GetByIdAsync(long id);

    Task<PageResponse<Product>> GetByCategoryIdAsync(long categoryId,
        PageRequest pageRequest);

    Task<PageResponse<Product>> GetByNameContainingAsync(string searchTerm,
        PageRequest pageRequest);
}