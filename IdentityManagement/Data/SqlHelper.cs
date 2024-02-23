using Dapper;
using IdentityManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Data
{
    public static class SqlHelper
    {
        public static T GetRecord<T>(string spName, List<ParameterInfo> parameters)
        {
            T objRecord = default(T);
            using (SqlConnection objConnection = new SqlConnection(Utils.ConnectionString()))
            {
                objConnection.Open();
                DynamicParameters p = new DynamicParameters();
                foreach (var param in parameters)
                {
                    p.Add("@" + param.ParameterName, param.ParameterValue);
                }

                objRecord = SqlMapper.Query<T>(objConnection, spName, p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                objConnection.Close();
            }
            return objRecord;
        }

        public static List<T> GetRecords<T>(string spName, List<ParameterInfo> parameters)
        {
            List<T> recordList = new List<T>();
            using (SqlConnection objConnection = new SqlConnection(Utils.ConnectionString()))
            {
                objConnection.Open();
                DynamicParameters p = new DynamicParameters();
                foreach (var param in parameters)
                {
                    p.Add("@" + param.ParameterName, param.ParameterValue);
                }

                recordList = SqlMapper.Query<T>(objConnection, spName, p, commandType: CommandType.StoredProcedure).ToList();
                objConnection.Close();
            }
            return recordList;
        }

        public static int GetIntRecord<T>(string spName, List<ParameterInfo> parameters)
        {
            int intRecord = 0;
            using (SqlConnection objConnection = new SqlConnection(Utils.ConnectionString()))
            {
                objConnection.Open();
                DynamicParameters p = new DynamicParameters();
                foreach (var param in parameters)
                {
                    p.Add("@" + param.ParameterName, param.ParameterValue);
                }

                using (var reader = SqlMapper.ExecuteReader(objConnection, spName, p, commandType: CommandType.StoredProcedure))
                {
                    if (reader != null && reader.Read())
                    {
                        intRecord = Convert.ToInt32(reader[0].ToString());
                    }
                }
                objConnection.Close();
            }
            return intRecord;
        }

        public static int ExecuteQuery(string spName, List<ParameterInfo> parameters)
        {
            int success = 0;
            using (SqlConnection objConnection = new SqlConnection(Utils.ConnectionString()))
            {
                objConnection.Open();
                DynamicParameters p = new DynamicParameters();
                foreach (var param in parameters)
                {
                    p.Add("@" + param.ParameterName, param.ParameterValue);
                }
                success = SqlMapper.Execute(objConnection, spName, p, commandType: CommandType.StoredProcedure);
                objConnection.Close();
            }
            return success;
        }
        
        public static int ExecuteQueryWithIntOutputParam(string spName, List<ParameterInfo> parameters)
        {
            int success = 0;
            using (SqlConnection objConnection = new SqlConnection(Utils.ConnectionString()))
            {
                objConnection.Open();
                DynamicParameters p = new DynamicParameters();
                foreach (var param in parameters)
                {
                    p.Add("@" + param.ParameterName, param.ParameterValue);
                }
                success = SqlMapper.Execute(objConnection, spName, p, commandType: CommandType.StoredProcedure);
                objConnection.Close();
            }
            return success;
        }

        public static int ExecuteProcedure(string spName, object param)
        {
            int res = 0;
            using (SqlConnection con = new SqlConnection(Utils.ConnectionString()))
            {
                con.Open();
                res = con.Execute(spName, param,commandType: CommandType.StoredProcedure);
            }
            return res;
        }
        public static int ExecuteQuery(string commandText, object param)
        {
            int res = 0;
            using (SqlConnection con = new SqlConnection(Utils.ConnectionString()))
            {
                con.Open();
                res = con.Execute(commandText, param, commandType: CommandType.Text);
            }
            return res;
        }
        public static int ExecuteScaler(string spName, object param)
        {
            int res = 0;
            using (SqlConnection con = new SqlConnection(Utils.ConnectionString()))
            {
                con.Open();
                res = Convert.ToInt32(con.ExecuteScalar(spName, param, commandType: CommandType.Text));
            }
            return res;
        }
    }
}
