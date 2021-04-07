using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace LoginAndRegistration.Models
{
    public static class DapperMethods
    {
        private static string connectionstring = "Server=.;Database=LoginAndRegistration;Trusted_Connection=True;MultipleActiveResultSets=true";

        public static void ExecuteWithOutReturn(string procedureName, DynamicParameters param)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                con.Execute(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }

        public static T ReturnUser<T>(string procedureName, DynamicParameters param)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                return con.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
    }
}
