using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class UserServices
    {
        public static User GetUserByUsername(string userName, string password)
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Users.SingleOrDefault(s => s.UserName == (string)userName && s.Password == (string) password);
            }
        }

        public static User GetUserByID(int userID)
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Users.SingleOrDefault(s => s.Id == (int)userID);
            }
        }

 //       public static string GetTypeOfUser(int userID)
    //    {
    //        using (var ctx = new CompanyDbContext())
    //        {

   //             return ctx.Users.SingleOrDefault.(s => s.UserName == (string)userName && s.Password == (string)password);
    //        }
    //    }

        //public static bool InsertUser(string username, string password, string first_name, string last_name, string gender, DateTime dateOfBirth, int department, int typeOfUser)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        bool retVal = false;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "insertUser";
        //        cmd.Parameters.AddWithValue("@userName", username);
        //        cmd.Parameters.AddWithValue("@password", password);
        //        cmd.Parameters.AddWithValue("@firstName", first_name);
        //        cmd.Parameters.AddWithValue("@lastName", last_name);
        //        cmd.Parameters.AddWithValue("@gender", gender);
        //        cmd.Parameters.AddWithValue("@birthday", dateOfBirth);
        //        cmd.Parameters.AddWithValue("@departmentID", department);
        //        cmd.Parameters.AddWithValue("@typeOfUserID", typeOfUser);
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

        //public static bool UpdateUser(int id, string first_name, string last_name, string gender, DateTime dateOfBirth, int department, int typeOfUser)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        bool retVal = false;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "updateUser";
        //        cmd.Parameters.AddWithValue("@userId", id);
        //        cmd.Parameters.AddWithValue("@firstName", first_name);
        //        cmd.Parameters.AddWithValue("@lastName", last_name);
        //        cmd.Parameters.AddWithValue("@gender", gender);
        //        cmd.Parameters.AddWithValue("@birthday", dateOfBirth);
        //        cmd.Parameters.AddWithValue("@departmentID", department);
        //        cmd.Parameters.AddWithValue("@typeOfUserID", typeOfUser);
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

        public static List<User> GetAllUsers()
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Users.ToList();
            }
        }

        //public static List<User> GetAllAdministrators()
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        List<User> users = new List<User>();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getAllAdministrators";
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            User u = new User();
        //            u.Create(result);
        //            users.Add(u);
        //        }

        //        sqlConn.Close();
        //        return users;
        //    }
        //}

        //public static List<User> GetAllManagers()
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        List<User> users = new List<User>();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getAllManagers";
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            User u = new User();
        //            u.Create(result);
        //            users.Add(u);
        //        }

        //        sqlConn.Close();
        //        return users;
        //    }
        //}

        //public static List<User> GetAllEmployees()
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        List<User> users = new List<User>();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getAllEmployees";
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            User u = new User();
        //            u.Create(result);
        //            users.Add(u);
        //        }

        //        sqlConn.Close();
        //        return users;
        //    }
        //}

        //public static bool PromoteEmployeeToManager(User user)
        //{
        //    if (user.TypeOfUserID.IsEmployee)
        //    {
        //        bool retVal = false;
        //        bool isManager = true;
        //        TypeOfUser manager = TypeOfUserServices.GetManagerIdByType(isManager, out retVal);

        //        if (retVal)  //ako je pronasao managera
        //        {
        //            bool promoted = UpdateEmployeeToManager(user.Id, manager.Id);
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    return false;

        //}

        //public static bool UpdateEmployeeToManager(int id, int managerID)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        bool retVal = false;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "updateEmployeeToManager";
        //        cmd.Parameters.AddWithValue("@userId", id);
        //        cmd.Parameters.AddWithValue("@typeOfUserID", managerID);
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

        //public static List<User> GetEmployeesOnDepartment(int managerDepartmentID)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        List<User> users = new List<User>();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getEmployeesOnDepartment";
        //        cmd.Parameters.AddWithValue("@departmentID", managerDepartmentID);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            User u = new User();
        //            u.Create(result);
        //            users.Add(u);
        //        }

        //        sqlConn.Close();
        //        return users;
        //    }
        //}

        //public static List<User> GetManagersForEmployee(int employeeID)
        //{
        //    using (SqlConnection sqlConn = new SqlConnection(connectionString))
        //    {
        //        List<User> users = new List<User>();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "getManagersForEmployee";
        //        cmd.Parameters.AddWithValue("@employeeID", employeeID);
        //        cmd.Connection = sqlConn;

        //        sqlConn.Open();

        //        var result = cmd.ExecuteReader();
        //        while (result.Read())
        //        {
        //            User u = new User();
        //            u.Create(result);
        //            users.Add(u);
        //        }

        //        sqlConn.Close();
        //        return users;
        //    }
        //}
    }
}
