using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebAPIProj1.Model;

namespace TestWebAPIProj1.Data
{
    public interface IProduct
    {
        List<Product> GetProducts();
        Product GetProduct(Guid id);
       
        void UpdateProduct();
        void DeleteProduct();

    }
}
