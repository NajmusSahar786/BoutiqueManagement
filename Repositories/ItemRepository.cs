using BoutiqueManagement.Models;
using IdentityManagement.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using BoutiqueManagement.IRepositories;

namespace BoutiqueManagement.Repositories
{
    public class ItemRepository:BaseRepository,IItemRepository
    {
        public List<Item> GetItems()
        {
            List<Item> result = null;
            try
            {
               
                using (var db = new SqlConnection(ConnectionString))
                {
                   result= SqlHelper.GetList<Item>("usp_GetAll_Items");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public List<Category> CategoryList()
        {
            List<Category> result = null;
            try
            {

                using (var db = new SqlConnection(ConnectionString))
                {
                    result = SqlHelper.GetList<Category>("usp_GetAllCategories");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public List<Brand> BrandList()
        {
            List<Brand> result = null;
            try
            {

                using (var db = new SqlConnection(ConnectionString))
                {
                    result = SqlHelper.GetList<Brand>("usp_Get_Brands");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
    }
}