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
                new Department {Id = 1, Name = "Undefined", Description = "Lorem Ipsum is simply dummy text", Active  = true, CompanyID = company1 },
                new Department {Id = 2, Name = "Production", Description = "The point of using lorem ipsum", Active  = true, CompanyID = company1},
                new Department {Id = 3, Name = "Marketing", Description = "There are many variations of passages", Active  = true, CompanyID = company1},
                new Department {Id = 4, Name = "Sales", Description = "The standard chunk of Lorem Ipsum used  ", Active  = true, CompanyID = company1}
            };
            context.Departments.AddRange(departments);

            var typeOfUsers = new List<TypeOfUser>()
            {
                new TypeOfUser {Id = 1, Name = "Administrator", Description = "Administrator is person who ...", IsAdministrator = true, IsEmployee = false, IsManager = false }
            };
            context.TypeOfUsers.AddRange(typeOfUsers);

            var users = new List<User>()
            {
                new User {Id = 1, UserName = "admin", Password = "admin", FirstName = "Sladjana", LastName = "Kalanj", Birthday = new System.DateTime(1976,8,9), Gender = 'f', DepartmentID = departments.Single(x => x.Id.Equals(1)), TypeOfUserID = typeOfUsers.Single(x => x.Id.Equals(1)) }
            };
            context.Users.AddRange(users);



            var projects = new List<Project>();
            var tasks = new List<Task>();




        base.Seed(context);
    }
}
}
