using BoutiqueManagement.IServices;
using BoutiqueManagement.Models;
using IdentityManagement.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BoutiqueManagement.Services
{
    public class ProductCatalog : IProductCatalog
    {
        private readonly IDbConnection _dbConnection;

        public ProductCatalog(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Product GetProduct(int id)
        {
            Product obj = new Product();
            
            return obj;
        }
        public int GetProductbyId(int id)
        {
            int success = SqlHelper.ExecuteQuery("NewUserRole", new { id = id });
            return success;
        }
        //public List<Product> GetProducts()
        //{
        //    List<Product> products = new List<Product>();
            
        //}
    }

}