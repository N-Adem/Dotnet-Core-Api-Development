using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebAPIProj1.Data;

namespace TestWebAPIProj1.Controllers
{

    [ApiController]
    public class ProductController : ControllerBase
    {
        IProduct _productData;
        public ProductController(IProduct productData) {
            _productData = productData;
        }

        [HttpGet]
        [Route("api/[controller]/")]
        public IActionResult GetProducts()
        {
            return Ok(_productData.GetProducts());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetProduct(Guid id) {
            return Ok(_productData.GetProduct(id));
        }
    }
}
