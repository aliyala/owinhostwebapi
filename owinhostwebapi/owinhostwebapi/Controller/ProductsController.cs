using Owinhostwebapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace owinhostwebapi.Controller
{
    public class ProductsController : ApiController
    {
        private Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "ProductA" },
            new Product { Id = 2, Name = "ProductB" }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }
    }
}