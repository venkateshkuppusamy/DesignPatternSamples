using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Decorator.CacheDecorator.Models;

namespace Decorator.CacheDecorator.Repositories
{
    public class CloudProductRepository : IProductRepository
    {
        private readonly List<Product> products;
        public CloudProductRepository()
        {
            products = new List<Product>();
            for (int i = 0; i < 20; i++)
            {
                products.Add(new Product() { Id = i, Name = "Cloud Product" + i, Description = "Cloud Description" + i });
            }
        }
        public List<Product> GetAll()
        {
            Console.WriteLine("Fetching all Cloud Products");
            Task.Delay(1000).Wait();
            return products;
        }

        public Product GetById(int id)
        {
            Console.WriteLine("Fetching Cloud product by id");
            Task.Delay(1000).Wait();
            return products.Find(f => f.Id == id);
        }
    }
}
