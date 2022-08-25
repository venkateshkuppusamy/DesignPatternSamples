using Decorator.CacheDecorator.Models;
using Decorator.CacheDecorator.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.CacheDecorator.Decorator
{
    internal class ProductRepositoryDecorator : IProductRepository
    {
        private readonly IProductRepository productRepository;
        
        protected ProductRepositoryDecorator(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public virtual List<Product> GetAll() {
           return  productRepository.GetAll();
        }
        public virtual Product GetById(int id)
        {
            return productRepository.GetById(id);
        }
    }
}
