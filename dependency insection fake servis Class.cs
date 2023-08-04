using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DamlaNurGuney.Sipay.Hafta1
    //interface oluşturmak için
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }


    public class dependency_insection_fake_servis_Class
    {
        public class FakeProductService : IProductService
        {
            private readonly List<Product> products;

            public FakeService() => products = new List<Product>

                {
        if (Products.Count == 0)
            for (int i = 1; i< 10; i++)
            {
                var product = new Product.Product
                {
                    Id = i,
                    Name = $"Product-{i}",
                    Prize = i * 10
                };

          
            }


    }


      
        };





        }
    }
