using AutomapperExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomapperExample.Repositories
{
    public class ProductRepository : IProductRepository
    {


        List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>()
            {
                new Product{ Id=Guid.NewGuid(), Name="Phone", Description="Nice phone", CreateDate=DateTime.UtcNow },
                new Product{ Id=Guid.NewGuid(), Name="Laptop", Description="Nice laptop", CreateDate=DateTime.UtcNow },
                new Product{ Id=Guid.NewGuid(), Name="Tv", Description="Nice tv", CreateDate=DateTime.UtcNow },
            };
        }
        public Guid AddProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            product.CreateDate = DateTime.UtcNow;
            product.Name = "desk";
            product.Description = "Nice desk";
            products.Add(product);
            var addedProduct = GetProductById(product.Id);
            return addedProduct.Id;
        }

        public bool DeleteProduct(Guid id)
        {
            var deletedProduct = GetProductById(id);
            if (products == null)
            {
                return false;
            }
            products.Remove(deletedProduct);
            return true;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(Guid id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            //var product = GetProductById(id);
            return product;
        }

        public Product UpdateProduct(Product product)
        {
            var updatedProduct = GetProductById(product.Id);
            if (updatedProduct != null)
            {
                updatedProduct.Name = product.Name;
                updatedProduct.Id = product.Id;
                updatedProduct.Description = product.Description;
            }
            return updatedProduct;
        }
    }
}
