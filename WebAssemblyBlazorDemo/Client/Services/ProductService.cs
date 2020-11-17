using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAssemblyBlazorDemo.Shared;

namespace WebAssemblyBlazorDemo.Client.Services
{
    public class ProductService : IProductService
    {
        private List<Product> products = new List<Product>();
        public ProductService()
        {
            SeedProducts();
        }
        public void AddProduct(Product newProduct)
        {
            products.Add(newProduct);
        }

        public void DeleteProduct(Product product)
        {
            this.products.Remove(product);
        }

        public List<Product> GetAllProduct()
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            return this.products.SingleOrDefault(x => x.Id == id);
        }

        public void SeedProducts()
        {
            products.AddRange(
                new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Dogfood",
                    Price = 10.99m,
                    VatPercentage = 21,
                    ProductImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4f/Hundefutter.jpg"
                },
            new Product
            {
                Id = 2,
                Name = "Catfood",
                Price = 8.99m,
                VatPercentage = 21,
                ProductImageUrl =
                    "https://upload.wikimedia.org/wikipedia/commons/1/16/Whiskas_cat%27s_petfood_with_chicken_dry.jpg"
            },
            new Product
            {
                Id = 3,
                Name = "Cat litter 50 liter",
                Price = 15.12m,
                VatPercentage = 21,
                ProductImageUrl = "https://www.publicdomainpictures.net/pictures/30000/velka/cat-litter.jpg"
            }
                }
                );
        }
    }
}
