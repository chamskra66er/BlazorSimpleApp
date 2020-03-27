using NewBlazor.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBlazor.Server.Services
{
    public interface IProduct
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        Task Create(Product product);
        Task Delete(Product product);
    }
}
