using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebAPIProj1.Model;

namespace TestWebAPIProj1.Data
{
    public class ProductData : IProduct
    {
        List<Product> _listOfProducts = new List<Product>() {
            new Product(){
                Id = Guid.NewGuid(),
                ProductName = "Cheese"
            },
            new Product(){
                Id = Guid.NewGuid(),
                ProductName = "Bread"
            }
        };

        public void DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(Guid id)
        {
            foreach (var product in _listOfProducts) {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }

        public List<Product> GetProducts()
        {
            return _listOfProducts;
        }

        public void UpdateProduct()
        {
        throw new NotImplementedException();
        }
    }
}
