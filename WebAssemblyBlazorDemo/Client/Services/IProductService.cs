using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAssemblyBlazorDemo.Shared;

namespace WebAssemblyBlazorDemo.Client.Services
{
    public interface IProductService
    {
        List<Product> GetAllProduct();

        Product GetProduct(int id);

        void DeleteProduct(Product product);

        void AddProduct(Product newProduct);
    }
}
