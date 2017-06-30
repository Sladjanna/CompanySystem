using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class TaskServices
    {
        //public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString();


        //public static List<Task> GetTasksByManager(int managerId)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        List<Task> tasks = new List<Task>();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getTasksByManager";
        //        cmd.Parameters.AddWithValue("@manID", managerId);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            Task t = new Task();
        //            t.Create(result);
        //            tasks.Add(t);
        //        }
        //        sqlConn.Close();
        //        return tasks;
        //    }
        //}

        //public static List<Task> GetTasksByEmployeeOnProject(int employeeID, int projectID)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        List<Task> tasks = new List<Task>();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getTasksByEmployeeOnProject";
        //        cmd.Parameters.AddWithValue("@employeeID", employeeID);
        //        cmd.Parameters.AddWithValue("@projectID", projectID);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            Task t = new Task();
        //            t.Create(result);
        //            tasks.Add(t);
        //        }

        //        sqlConn.Close();
        //        return tasks;
        //    }
        //}

        //public static void InsertTask(string title, DateTime startDate, DateTime endDate, int estimated, int remainig, string description, string comment, string stateOfTask, int projectID, int userID)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "insertTask";
        //        cmd.Parameters.AddWithValue("@title", title);
        //        cmd.Parameters.AddWithValue("@start", startDate);
        //        cmd.Parameters.AddWithValue("@end", endDate);
        //        cmd.Parameters.AddWithValue("@estimated", estimated);
        //        cmd.Parameters.AddWithValue("@remaining", remainig);
        //        cmd.Parameters.AddWithValue("@desc", description);
        //        cmd.Parameters.AddWithValue("@comment", comment);
        //        cmd.Parameters.AddWithValue("@state", stateOfTask);
        //        cmd.Parameters.AddWithValue("@ProjectID", projectID);
        //        cmd.Parameters.AddWithValue("@UserID", userID);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        cmd.ExecuteReader();
        //        sqlConn.Close();
        //    }
        //}

        //public static bool UpdateTaskByEmployee(int taskID, int estimated, int remainig, string comment, string stateOfTask)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        bool retVal = false;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "updateTaskByEmployee";
        //        cmd.Parameters.AddWithValue("@id", taskID);
        //        cmd.Parameters.AddWithValue("@estimated", estimated);
        //        cmd.Parameters.AddWithValue("@remainig", remainig);
        //        cmd.Parameters.AddWithValue("@comment", comment);
        //        cmd.Parameters.AddWithValue("@stateOfTask", stateOfTask);
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

        //public static bool deleteTask(Task task)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        bool retVal = false;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "deleteTask";
        //        cmd.Parameters.AddWithValue("@id", task.Id);
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
