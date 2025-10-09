using AspNetEcommerce.API.entities;
using AspNetEcommerce.API.services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetEcommerce.API.controller;

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
    public async Task<ActionResult<IEnumerable<Product>>> GetAllAsync()
    {
        var products = await _productService.GetAllAsync();
        return Ok(products);
    }


    [HttpGet("{id:long}")]
    public async Task<ActionResult<Product>> GetByIdAsync(long id)
    {
        var product = await _productService.GetByIdAsync(id);
        if (product == null) return NotFound();
        return Ok(product);
    }

    [HttpGet("category/{categoryId:long}")]
    public async Task<ActionResult<Product>> GetByCategoryIdAsync(
        long categoryId)
    {
        var product = await _productService.GetByCategoryIdAsync(categoryId);
        if (product == null) return NotFound();
        return Ok(product);
    }

    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<Product>>>
        GetByNameContainingAsync(
            [FromQuery] string searchTerm)
    {
        var products =
            await _productService.GetByNameContainingAsync(searchTerm);
        return Ok(products);
    }
}