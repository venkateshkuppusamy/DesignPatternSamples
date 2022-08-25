using Decorator.CacheDecorator.Decorator;
using Decorator.CacheDecorator.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.CacheDecorator
{
    internal class Startup
    {
        public static void Run() {
            
           // IProductRepository productRepository = new CloudProductRepository();
            IProductRepository productRepository = new ProductRepositoryCacheDecorator(new CloudProductRepository());
            var products = productRepository.GetAll();
            products.ForEach(e => Console.WriteLine($"Id: {e.Id}, Name: {e.Name}, Description: {e.Description}"));
            products = productRepository.GetAll();
            products.ForEach(e => Console.WriteLine($"Id: {e.Id}, Name: {e.Name}, Description: {e.Description}"));

        }
    }
}
