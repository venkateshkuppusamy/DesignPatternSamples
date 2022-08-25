using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Decorator.CacheDecorator.Models;

namespace Decorator.CacheDecorator.Repositories
{
    public class LegacyProductRespository : IProductRepository
    {
        private readonly List<Product> products;
        public LegacyProductRespository()
        {
            products = new List<Product>();
            for (int i = 0; i < 20; i++)
            {
                products.Add(new Product() { Id = i, Name = "Legacy Product" + i, Description = "Legacy Description" + i });
            }
        }

        public List<Product> GetAll()
        {
            Console.WriteLine("Fetching all Legacy Products");
            Task.Delay(1500).Wait();
            return products;
        }

        public Product GetById(int id)
        {
            Console.WriteLine("Fetching Legacy product by id");
            Task.Delay(1500).Wait();
            return products.Find(f => f.Id == id);
        }
    }
}
