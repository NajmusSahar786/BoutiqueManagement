using IdentityManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BoutiqueManagement.Repositories
{
    public class BaseRepository
    {
        readonly IDbConnection dbConnection = new SqlConnection(Utils.ConnectionString());
        public IDbConnection Connection
        {
            get 
            {
                return dbConnection; 
            }
        }
        public string ConnectionString
        {
            get 
            {
                return Utils.ConnectionString().ToString();
            }
        }

    }
}