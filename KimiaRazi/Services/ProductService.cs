using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using KimiaRazi.DataAccess;
using KimiaRazi.Models;
using KimiaRazi.Services;

namespace Bakery.Services
{
    public class ProductService : IProductService
    {
        public Product GetProduct(int id)
        {
            using (DefaultConnection context = new DefaultConnection())
            {
                return context.Products.Find(id);
            }
        }
    }
}