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
                    SqlHelper.ExecuteProcedure("usp_GetAll_Items", new { });
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