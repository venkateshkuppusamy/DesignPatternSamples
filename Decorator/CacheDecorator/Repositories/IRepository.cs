using System.Collections.Generic;
using System.Text;
using Decorator.CacheDecorator.Models;

namespace Decorator.CacheDecorator.Repositories
{
    internal interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
    }
}
