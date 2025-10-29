using AspNetEcommerce.API.dto;
using AspNetEcommerce.API.entities;
using AspNetEcommerce.API.repositories;

namespace AspNetEcommerce.API.services;

/// <inheritdoc cref="IProductService"/>
public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<PageResponse<Product>> GetAllAsync(PageRequest pageRequest)
    {
        var items = await _productRepository.GetAllAsync(pageRequest);
        var total = await _productRepository.CountAllAsync();
        return new PageResponse<Product>(items, total, pageRequest.PageNumber, pageRequest.PageSize);
    }

    public Task<Product?> GetByIdAsync(long id)
    {
        return _productRepository.GetByIdAsync(id);
    }

    public async Task<PageResponse<Product>> GetByCategoryIdAsync(long categoryId,
        PageRequest pageRequest)
    {
        var items = await _productRepository.GetByCategoryIdAsync(categoryId, pageRequest);
        var total = await _productRepository.CountByCategoryIdAsync(categoryId);
        return new PageResponse<Product>(items, total, pageRequest.PageNumber, pageRequest.PageSize);
    }

    public async Task<PageResponse<Product>> GetByNameContainingAsync(
        string searchTerm, PageRequest pageRequest)
    {
        var items = await _productRepository.GetByNameContainingAsync(searchTerm, pageRequest);
        var total = await _productRepository.CountByNameContainingAsync(searchTerm);
        return new PageResponse<Product>(items, total, pageRequest.PageNumber, pageRequest.PageSize);
    }
}