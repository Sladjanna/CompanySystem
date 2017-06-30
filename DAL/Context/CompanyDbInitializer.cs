using Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class CompanyDbInitializer : DropCreateDatabaseAlways<CompanyDbContext>
    {
        protected override void Seed(CompanyDbContext context)
        {
            var company1 = new Company { Id = 1, NameOfCompany = "Zesium" };
            context.Companies.Add(company1);

            var departments = new List<Department>()
            {
                new Department {Id = 1, Name = "Undefined", Description = "Lorem Ipsum is simply dummy text", Active  = true, CompanyID = 1 },
                new Department {Id = 2, Name = "Production", Description = "The point of using lorem ipsum", Active  = true, CompanyID = 1},
                new Department {Id = 3, Name = "Marketing", Description = "There are many variations of passages", Active  = true, CompanyID = 1},
                new Department {Id = 4, Name = "Sales", Description = "The standard chunk of Lorem Ipsum used  ", Active  = true, CompanyID = 1}
            };
            context.Departments.AddRange(departments);


            var typeOfUsers = new List<TypeOfUser>()
            {
                new TypeOfUser {Id = 1, Name = "Administrator", Description = "Administrator is person who ...", IsAdministrator = true, IsEmployee = false, IsManager = false },
                new TypeOfUser {Id = 2, Name = "Manager", Description = "Manager is person who ...", IsAdministrator = false, IsEmployee = false, IsManager = true },
                new TypeOfUser {Id = 3, Name = "Employee", Description = "Employee is person who ...", IsAdministrator = true, IsEmployee = true, IsManager = false }
            };
            context.TypeOfUsers.AddRange(typeOfUsers);


            var users = new List<User>()
            {
                new User {Id = 1, UserName = "admin", Password = "admin", FirstName = "Sladjana", LastName = "Kalanj", Birthday = new System.DateTime(1976,8,9), Gender = "f", DepartmentID = 1, TypeOfUserID = 1 },
                new User {Id = 2, UserName = "m1", Password = "m1", FirstName = "Marko", LastName = "Markovic", Birthday = new System.DateTime(1988,10,10), Gender = "m", DepartmentID = 1, TypeOfUserID = 2 },
                new User {Id = 3, UserName = "e1", Password = "e1", FirstName = "Ivana", LastName = "Ivanovic", Birthday = new System.DateTime(1992,2,3), Gender = "f", DepartmentID = 1, TypeOfUserID = 3 }
            };
            context.Users.AddRange(users);



            //var projects = new List<Project>()
            //{
            //    new Project {Id = 1, Title = "Project1", Description = "Description of project1", StartDate = new System.DateTime(2017,6,6), EndDate = new System.DateTime(2017,6,6), Cost = 8000, StateOfProject = "New", DepartmentID = 1, ManagerID = 2}
            //};
            //context.Projects.AddRange(projects);


            //var tasks = new List<Task>()
            //{
            //    new Task {Id = 1, Title = "Task1 for Project1", Description = "Description of task...", Comment = " ", EstimatedWorkingHour = 80, RemainingWorkingHour = 80, StartDate = new System.DateTime(2017,6,7), EndDate = new System.DateTime(2017,6,20), StateOfTask = "ToDo", ProjectID = 1, UserID = 3 }
            //};
            //context.Tasks.AddRange(tasks);



            base.Seed(context);
    }
}
}
