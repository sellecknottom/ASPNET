using Dapper;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Data;


namespace Testing.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Microsoft.Build.Tasks.Deployment.Bootstrapper.Product> GetAllProducts()
        {
            return _conn.Query<Microsoft.Build.Tasks.Deployment.Bootstrapper.Product>("SELECT * FROM PRODUCTS;");
        }
    }
}
