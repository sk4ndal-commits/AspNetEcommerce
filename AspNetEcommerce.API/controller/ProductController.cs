using AspNetEcommerce.API.dto;
using AspNetEcommerce.API.entities;
using AspNetEcommerce.API.services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetEcommerce.API.controller;

/// <summary>
/// REST API controller for managing product-related operations.
/// Provides endpoints to retrieve products, search by name, filter by category,
/// and implement pagination.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<PageResponse<Product>>> GetAllAsync(
        [FromQuery] PageRequest pageRequest)
    {
        var page = await _productService.GetAllAsync(pageRequest);
        return Ok(page);
    }


    [HttpGet("{id:long}")]
    public async Task<ActionResult<Product>> GetByIdAsync(long id)
    {
        var product = await _productService.GetByIdAsync(id);
        return product is not null ? Ok(product) : NotFound();
    }

    [HttpGet("category/{categoryId:long}")]
    public async Task<ActionResult<PageResponse<Product>>> GetByCategoryIdAsync(
        [FromQuery] PageRequest pageRequest,
        long categoryId)
    {
        var page = await _productService
            .GetByCategoryIdAsync(categoryId, pageRequest);
        return Ok(page);
    }

    [HttpGet("search")]
    public async Task<ActionResult<PageResponse<Product>>>
        GetByNameContainingAsync(
            [FromQuery] string searchTerm,
            [FromQuery] PageRequest pageRequest)
    {
        var page = await _productService
            .GetByNameContainingAsync(searchTerm, pageRequest);
        return Ok(page);
    }
}