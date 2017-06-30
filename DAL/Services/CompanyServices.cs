using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class CompanyServices
    {
        //      public static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString();


        //public static Company GetCompanyByID(int id)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        Company com = new Company();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getCompanyByID";
        //        cmd.Parameters.AddWithValue("@comID", id);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();

        //        while (result.Read())
        //        {
        //            var val = result.GetValue(0);
        //            if (val != null && Convert.ToBoolean(val) == true)
        //            {
        //                com.Create(result);
        //            }
        //        }
        //        sqlConn.Close();
        //        return com;
        //    }
        //}

        public static List<Company> GetCompanies()
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Companies.ToList();
            }

        }
    }
}
