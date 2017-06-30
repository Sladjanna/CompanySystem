using Model;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Services
{
    public class DepartmentServices
    {
        public static List<Department> GetDepartments()
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Departments.ToList();
            }
        }

        //public static Department GetDepartmentByID(int id)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        Department dep = new Department();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getDepartmentByID";
        //        cmd.Parameters.AddWithValue("@depID", id);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();

        //        while (result.Read())
        //        {
        //            var val = result.GetValue(0);
        //            if (val != null && Convert.ToBoolean(val) == true)
        //            {
        //                dep.Create(result);
        //            }
        //        }
        //        sqlConn.Close();
        //        return dep;
        //    }
        //}

        //public static bool InsertDepartment(string nameOfDepartment, string descriptionOfDepartment, bool active, int companyID)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        bool retVal = false;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "insertDepartment";
        //        cmd.Parameters.AddWithValue("@nameOfDep", nameOfDepartment);
        //        cmd.Parameters.AddWithValue("@descOfDep", descriptionOfDepartment);
        //        cmd.Parameters.AddWithValue("@active", active);
        //        cmd.Parameters.AddWithValue("@companyID", companyID);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            var val = result.GetValue(0);
        //            if (val != null && Convert.ToBoolean(val) == true)
        //            {
        //                retVal = true;
        //            }
        //        }
        //        sqlConn.Close();
        //        return retVal;
        //    }
        //}

        //public static bool UpdateDepartment(int id, string nameOfDepartment, string descriptionOfDepartment)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        bool retVal = false;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "updateDepartment";
        //        cmd.Parameters.AddWithValue("@depId", id);
        //        cmd.Parameters.AddWithValue("@depName", nameOfDepartment);
        //        cmd.Parameters.AddWithValue("@depDescrip", descriptionOfDepartment);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            var val = result.GetValue(0);
        //            if (val != null && Convert.ToBoolean(val) == true)
        //            {
        //                retVal = true;
        //            }
        //        }
        //        sqlConn.Close();

        //        return retVal;
        //    }
        //}

        //public static bool deleteDepartment(int dep)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        bool retVal = false;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "deleteDepartment";
        //        cmd.Parameters.AddWithValue("@depID", dep);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            var val = result.GetValue(0);
        //            if (val != null && Convert.ToBoolean(val) == true)
        //            {
        //                retVal = true;
        //            }
        //        }
        //        sqlConn.Close();

        //        return retVal;
        //    }
        //}
             
    }
}
