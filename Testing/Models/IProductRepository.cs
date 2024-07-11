using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using Testing.Models;

namespace Testing.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Microsoft.Build.Tasks.Deployment.Bootstrapper.Product> GetAllProducts();
    }
}
