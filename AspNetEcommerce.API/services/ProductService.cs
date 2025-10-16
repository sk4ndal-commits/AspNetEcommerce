using AspNetEcommerce.API.dto;
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

    public async Task<IEnumerable<Product>> GetAllAsync(PageRequest pageRequest)
    {
        return await _productRepository.GetAllAsync(pageRequest);
    }

    public Task<Product?> GetByIdAsync(long id)
    {
        return _productRepository.GetByIdAsync(id);
    }

    public Task<IEnumerable<Product>> GetByCategoryIdAsync(long categoryId,
        PageRequest pageRequest)
    {
        return _productRepository.GetByCategoryIdAsync(categoryId, pageRequest);
    }

    public Task<IEnumerable<Product>> GetByNameContainingAsync(
        string searchTerm, PageRequest pageRequest)
    {
        return _productRepository.GetByNameContainingAsync(searchTerm,
            pageRequest);
    }
}