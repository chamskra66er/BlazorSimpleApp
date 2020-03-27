using NewBlazor.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBlazor.Server.Services
{
    public class ProductService : IProduct
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Create(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public Task Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.OrderBy(x=>x.ProductName);
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
