using DAL;
using Model;
using Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {
            using (var ctx = new CompanyDbContext())
            {
                var d = ctx.Departments.ToList();
                var u = ctx.Users.ToList();
                var p = ctx.Projects.ToList();
                var ta = ctx.Tasks.ToList();

                //User user = new User("e2", "e2", "employee2Name", "employee2LastName", "f", new DateTime(2000,8,8), 2, 2);
                //User user1 = UserServices.InsertUser(user);
                //if(user1 != null)
                //    Console.WriteLine("New User created");
                //else
                //    Console.WriteLine("Error creating user!");

                //Department department = new Department("department5", "description", true, 1);
                //Department department1 = DepartmentServices.InsertDepartment(department);
                //if (department1 != null)
                //    Console.WriteLine("New Department created");
                //else
                //    Console.WriteLine("Error creating department!");


                //User updateUser = new User(11, "admin", "admin", "Sladja", "K", "f", new DateTime(1976,9,8), 1, 1);
                //if (UserServices.UpdateUser(updateUser))
                //     Console.WriteLine("User updated");
                //else
                //    Console.WriteLine("Error updating user!");
            }

            Console.WriteLine("done");
            Console.ReadLine();
        }
    }
}
