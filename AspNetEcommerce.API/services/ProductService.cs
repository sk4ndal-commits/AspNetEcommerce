using AspNetEcommerce.API.entities;
using AspNetEcommerce.API.repositories;

namespace AspNetEcommerce.API.services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _productRepository.GetAllAsync();
    }

    public Task<Product?> GetByIdAsync(long id)
    {
        return _productRepository.GetByIdAsync(id);
    }

    public Task<Product?> GetByCategoryIdAsync(long categoryId)
    {
        return _productRepository.GetByCategoryIdAsync(categoryId);
    }

    public Task<IEnumerable<Product>> GetByNameContainingAsync(string searchTerm)
    {
        return _productRepository.GetByNameContainingAsync(searchTerm);
    }
}