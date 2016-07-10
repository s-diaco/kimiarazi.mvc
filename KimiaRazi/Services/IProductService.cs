using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KimiaRazi.Models;

namespace KimiaRazi.Services
{
    interface IProductService
    {
        Product GetProduct(int id);
    }
}
