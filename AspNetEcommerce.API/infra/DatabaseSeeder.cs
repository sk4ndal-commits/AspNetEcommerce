using AspNetEcommerce.API.db;
using AspNetEcommerce.API.entities;

namespace AspNetEcommerce.API.data;

public static class DatabaseSeeder
{
    public static async Task SeedAsync(EcommerceDbContext context)
    {
        // Check if data already exists
        if (context.ProductCategories.Any() || context.Products.Any())
        {
            return; // Database has been seeded
        }

        // Seed Categories
        var categories = new[]
        {
            new ProductCategory { CategoryName = "Electronics" },
            new ProductCategory { CategoryName = "Clothing" },
            new ProductCategory { CategoryName = "Books" },
            new ProductCategory { CategoryName = "Home & Garden" },
            new ProductCategory { CategoryName = "Sports & Outdoors" }
        };

        context.ProductCategories.AddRange(categories);
        await context.SaveChangesAsync();

        // Seed Products
        var products = new[]
        {
            // Electronics
            new Product
            {
                CategoryId = categories[0].Id,
                Sku = "ELEC001",
                Name = "Wireless Bluetooth Headphones",
                Description = "High-quality wireless headphones with noise cancellation",
                UnitPrice = 99.99m,
                ImageUrl = "https://example.com/images/headphones.jpg",
                Active = true,
                UnitsInStock = 50,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            },
            new Product
            {
                CategoryId = categories[0].Id,
                Sku = "ELEC002",
                Name = "Smartphone",
                Description = "Latest model smartphone with advanced features",
                UnitPrice = 699.99m,
                ImageUrl = "https://example.com/images/smartphone.jpg",
                Active = true,
                UnitsInStock = 25,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            },
            new Product
            {
                CategoryId = categories[0].Id,
                Sku = "ELEC003",
                Name = "Laptop Computer",
                Description = "High-performance laptop for work and gaming",
                UnitPrice = 1299.99m,
                ImageUrl = "https://example.com/images/laptop.jpg",
                Active = true,
                UnitsInStock = 15,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            },

            // Clothing
            new Product
            {
                CategoryId = categories[1].Id,
                Sku = "CLOTH001",
                Name = "Cotton T-Shirt",
                Description = "Comfortable 100% cotton t-shirt in various colors",
                UnitPrice = 19.99m,
                ImageUrl = "https://example.com/images/tshirt.jpg",
                Active = true,
                UnitsInStock = 100,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            },
            new Product
            {
                CategoryId = categories[1].Id,
                Sku = "CLOTH002",
                Name = "Denim Jeans",
                Description = "Classic fit denim jeans for everyday wear",
                UnitPrice = 59.99m,
                ImageUrl = "https://example.com/images/jeans.jpg",
                Active = true,
                UnitsInStock = 75,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            },

            // Books
            new Product
            {
                CategoryId = categories[2].Id,
                Sku = "BOOK001",
                Name = "Programming Fundamentals",
                Description = "Complete guide to learning programming concepts",
                UnitPrice = 39.99m,
                ImageUrl = "https://example.com/images/programming-book.jpg",
                Active = true,
                UnitsInStock = 30,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            },
            new Product
            {
                CategoryId = categories[2].Id,
                Sku = "BOOK002",
                Name = "Mystery Novel",
                Description = "Bestselling mystery novel with thrilling plot",
                UnitPrice = 14.99m,
                ImageUrl = "https://example.com/images/mystery-novel.jpg",
                Active = true,
                UnitsInStock = 60,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            },

            // Home & Garden
            new Product
            {
                CategoryId = categories[3].Id,
                Sku = "HOME001",
                Name = "Indoor Plant Pot",
                Description = "Decorative ceramic pot perfect for indoor plants",
                UnitPrice = 24.99m,
                ImageUrl = "https://example.com/images/plant-pot.jpg",
                Active = true,
                UnitsInStock = 40,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            },
            new Product
            {
                CategoryId = categories[3].Id,
                Sku = "HOME002",
                Name = "Coffee Maker",
                Description = "Automatic drip coffee maker with programmable timer",
                UnitPrice = 89.99m,
                ImageUrl = "https://example.com/images/coffee-maker.jpg",
                Active = true,
                UnitsInStock = 20,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            },

            // Sports & Outdoors
            new Product
            {
                CategoryId = categories[4].Id,
                Sku = "SPORT001",
                Name = "Yoga Mat",
                Description = "Non-slip yoga mat for exercise and meditation",
                UnitPrice = 29.99m,
                ImageUrl = "https://example.com/images/yoga-mat.jpg",
                Active = true,
                UnitsInStock = 80,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            },
            new Product
            {
                CategoryId = categories[4].Id,
                Sku = "SPORT002",
                Name = "Running Shoes",
                Description = "Lightweight running shoes with excellent cushioning",
                UnitPrice = 119.99m,
                ImageUrl = "https://example.com/images/running-shoes.jpg",
                Active = true,
                UnitsInStock = 45,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            }
        };

        context.Products.AddRange(products);
        await context.SaveChangesAsync();
    }
}
