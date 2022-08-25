using Decorator.CacheDecorator.Models;
using Decorator.CacheDecorator.Repositories;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;

namespace Decorator.CacheDecorator.Decorator
{
    internal class ProductRepositoryCacheDecorator : ProductRepositoryDecorator
    {
        private readonly IMemoryCache cache;
        public ProductRepositoryCacheDecorator(IProductRepository productRepository) : base(productRepository)
        {
            this.cache = new MemoryCache(new MemoryCacheOptions());
        }

        public override List<Product> GetAll()
        {
            cache.TryGetValue("Product", out List<Product> products);
            if (products == null)
            {
                products = base.GetAll();
                cache.Set("Product", products);
                return products;
            }
            Console.WriteLine("Fetching products from cache...");
            return products;
        }
    }
}
