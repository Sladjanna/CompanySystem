using DAL;
using DAL.Context;
using Model;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Services.Services
{
    public class AccountService
    {

        public bool LogIn(string username, string password)
        {
            User user;
            using (var ctx = new CompanyDbContext())
            {
                user = ctx.Users.Where(x => x.UserName.Equals(username) && x.Password.Equals(password))
                                .Include(x => x.Department).SingleOrDefault();

                if (user != null)
                {
                    Company.Instance.CurrentUser = user;
                    return true;
                }

                return false;
            }
        }

        public User GetUserByID(int userID)
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Users.SingleOrDefault(s => s.Id == (int)userID);
                //  var user = ctx.Users.Where(s => s.Id == (int)userID).Include(x => x.TypeOfUser).Include(x => x.Department).FirstOrDefault();
            }
        }



        //public void CreateAdmin(string username, string password, string name, string lastName, DateTime dayOfBirth, Gender gender)
        //{
        //    using (var ctx = new CompanyDbContext())
        //    {
        //        ctx.Users.Add(new User
        //        {
        //            Birthday = dayOfBirth,
        //            FirstName = name,
        //            LastName = lastName,
        //            Password = password,
        //            UserName = username,
        //            Gender = gender,
        //            UserType = UserType.Administrator
        //        });
        //        ctx.SaveChanges();
        //    }
        //}

        public User InsertUser(string username, string password, string firstName, string lastName, string gender, DateTime dateOfBirth, int departmentID)
        {
            var user = new User
            {
                UserName = username,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                Birthday = dateOfBirth,
                UserType = UserType.Employee,
                DepartmentID = departmentID
            };

            using (var ctx = new CompanyDbContext())
            {
                var newUser = ctx.Users.Add(user);
                ctx.SaveChanges();
                return newUser;
            }
        }

        public UserType getTypeOfUser(string userType)
        {
            if (userType == "Administrator")
                return UserType.Administrator;
            else if (userType == "Manager")
                return UserType.Manager;
            else
                return UserType.Employee;
        }

        public bool UpdateUser(User user)
        {
            User userForUpdate;
            using (var ctx = new CompanyDbContext())
            {
                userForUpdate = ctx.Users.Where(u => u.Id == user.Id).FirstOrDefault<User>();
                if (userForUpdate != null)
                {
                    userForUpdate.FirstName = user.FirstName;
                    userForUpdate.LastName = user.LastName;
                    userForUpdate.Birthday = user.Birthday;
                    userForUpdate.Gender = user.Gender;
                    userForUpdate.DepartmentID = user.DepartmentID;
                    userForUpdate.UserType = user.UserType;
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public List<User> GetAllUsers()
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Users.ToList();
            }
        }

        public List<User> GetAllAdministrators()
        {
            using (var ctx = new CompanyDbContext())
            {
                var admins = ctx.Users.Where(s => s.UserType.Equals("Administrator"));
                return (List<User>)admins;
            }
        }

        public List<User> GetAllManagers()
        {
            using (var ctx = new CompanyDbContext())
            {
                var managers = ctx.Users.Where(s => s.UserType.Equals("Manager"));
                return (List<User>)managers;
            }
        }

        public List<User> GetAllEmployees()
        {
            using (var ctx = new CompanyDbContext())
            {
                var employees = ctx.Users.Where(s => s.UserType.Equals("Employee"));
                return (List<User>)employees;
            }
        }

        //public bool PromoteEmployeeToManager(User user)
        //{


        //}
        public void PromoteEmployeeToManager(int id, Department department)
        {
            using (var ctx = ContextFactory.Create())
            {
                var user = ctx.Users.SingleOrDefault(x => x.Id.Equals(id));
                if (user == null) throw new Exception("Employee with given Id does not exist");

                user.DepartmentID = department.Id;
                user.UserType = UserType.Manager;

                ctx.SaveChanges();
            }
        }

        public void UpdateEmployeeToManager(int id, int managerID)
        {
            //User employeeForUpdate;
            //using (var ctx = new CompanyDbContext())
            //{
            //    employeeForUpdate = ctx.Users.Where(u => u.Id == user.Id).FirstOrDefault<User>();
            //    if (employeeForUpdate != null)
            //    {
            //        employeeForUpdate.TypeOfUserID = user.FirstName;
            //        ctx.SaveChanges();
            //        return true;
            //    }
            //    return false;
            //}
        }

        public List<User> GetAllEmployeesFromManagerDepartment(int departmentId)
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Users.Where(x => x.DepartmentID.Equals(departmentId) && x.UserType == UserType.Employee).ToList();
            }
        }

        //public List<User> GetEmployeesOnDepartment(int managerDepartmentID)
        //{
        //    using (var ctx = new CompanyDbContext())
        //    {

        //    }
        //}
        public void UpdateUsersWhenDepartmentIsCanceled(int departmentId)
        {
            using (var ctx = ContextFactory.Create())
            {
                var users = ctx.Users.Where(x => x.DepartmentID.Equals(departmentId)).ToList();

                users.ForEach(x => x.DepartmentID = 0);
                ctx.SaveChanges();
            }
        }

        public List<User> GetEmployeeManagers(int employeeID)
        {

            using (var ctx = new CompanyDbContext())
            {
                throw new NotImplementedException();
            }
        }



    }
}
