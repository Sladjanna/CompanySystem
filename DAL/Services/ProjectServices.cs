using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class ProjectServices
    {
        //public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString();


        //public static List<Project> GetProjectsByManager(int managerId)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        List<Project> projects = new List<Project>();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getProjectsByManager";
        //        cmd.Parameters.AddWithValue("@manID", managerId);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            Project p = new Project();
        //            p.Create(result);
        //            projects.Add(p);
        //        }

        //        sqlConn.Close();
        //        return projects;
        //    }
        //}

        //public static List<Project> GetProjectsByEmployee(int employeeId)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        List<Project> projects = new List<Project>();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getProjectsByEmployee";
        //        cmd.Parameters.AddWithValue("@employeeID", employeeId);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            Project p = new Project();
        //            p.Create(result);
        //            projects.Add(p);
        //        }

        //        sqlConn.Close();
        //        return projects;
        //    }
        //}

        //public static Project GetProjectByID(int projectID)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        Project project = new Project();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getProjectByID";
        //        cmd.Parameters.AddWithValue("@projectID", projectID);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();
        //        var result = cmd.ExecuteReader();

        //        while (result.Read())
        //        {
        //            var val = result.GetValue(0);
        //            if (val != null && Convert.ToBoolean(val) == true)
        //            {
        //                project.Create(result);
        //            }
        //        }
        //        sqlConn.Close();
        //        return project;
        //    }
        //}

        //public static bool InsertProject(string title, DateTime startDate, DateTime endDate, string description, decimal cost, string projectState, int departmentID, int managerID)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        bool retVal = false;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "insertProject";
        //        cmd.Parameters.AddWithValue("@title", title);
        //        cmd.Parameters.AddWithValue("@start", startDate);
        //        cmd.Parameters.AddWithValue("@end", endDate);
        //        cmd.Parameters.AddWithValue("@dec", description);
        //        cmd.Parameters.AddWithValue("@cost", cost);
        //        cmd.Parameters.AddWithValue("@state", projectState);
        //        cmd.Parameters.AddWithValue("@departmentID", departmentID);
        //        cmd.Parameters.AddWithValue("@managerID", managerID);
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

        //public static bool UpdateProject(int projectID, string title, DateTime startDate, DateTime endDate, string description, decimal cost, string projectState)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        bool retVal = false;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "updateProject";
        //        cmd.Parameters.AddWithValue("@id", projectID);
        //        cmd.Parameters.AddWithValue("@title", title);
        //        cmd.Parameters.AddWithValue("@start", startDate);
        //        cmd.Parameters.AddWithValue("@end", endDate);
        //        cmd.Parameters.AddWithValue("@dec", description);
        //        cmd.Parameters.AddWithValue("@cost", cost);
        //        cmd.Parameters.AddWithValue("@state", projectState);
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

        //public static bool UpdateState(int projectID, string projectState)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        bool retVal = false;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "updateState";
        //        cmd.Parameters.AddWithValue("@id", projectID);
        //        cmd.Parameters.AddWithValue("@state", projectState);
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

        //public static bool deleteProject(int project)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        bool retVal = false;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "deleteProject";
        //        cmd.Parameters.AddWithValue("@projectID", project);
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
