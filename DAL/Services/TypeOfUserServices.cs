using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class TypeOfUserServices
    {
        //public static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString();

        public static List<TypeOfUser> GetTypesOfUser()
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.TypeOfUsers.ToList();
            }

        }

        //public static TypeOfUser GetTypeByID(int typeOfUserID)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        TypeOfUser typeOfUser = new TypeOfUser();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getTypeByID";
        //        cmd.Parameters.AddWithValue("@typeID", typeOfUserID);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            typeOfUser.Create(result);
        //        }
        //        sqlConn.Close();
        //        return typeOfUser;
        //    }
        //}

        //public static TypeOfUser GetManagerIdByType(bool isManager, out bool retVal)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        retVal = false;
        //        TypeOfUser manager = new TypeOfUser();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getManagerIdByType";
        //        cmd.Parameters.AddWithValue("@typeManager", isManager);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();
        //        var result = cmd.ExecuteReader();

        //        while (result.Read())
        //        {
        //            var val = result.GetValue(0);
        //            if (val != null && Convert.ToBoolean(val) == true)
        //            {
        //                manager.Create(result);
        //                retVal = true;
        //            }
        //        }
        //        sqlConn.Close();
        //        return manager;
        //    }
        //}
    }
}
