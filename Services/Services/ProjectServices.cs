using DAL;
using DAL.Context;
using Model;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProjectServices
    {
        public List<Project> GetAllProjectsByManager(int managerId)
        {
            using (var ctx = new CompanyDbContext())
            {
                var projects = ctx.Projects.Where(s => s.Id == (int)managerId).ToList();
                return projects;
            }
        }

        public List<Project> GetProjectsOfEmployee(int employeeId)   //remane from GetProjectsOfEmployee
        {
            using (var ctx = new CompanyDbContext())
            {
                var user = ctx.Users.Where(x => x.Id.Equals(employeeId)).Include(x => x.Projects).Include(u => u.Department).SingleOrDefault();
                if (user == null)
                {
                    throw new Exception("User with provided ID does not exist");
                }
                return user.Projects.ToList();
            }
        }

        public Project GetProjectByID(int projectID)
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Projects.SingleOrDefault(s => s.Id == (int)projectID);
            }
        }

        public Project InsertProject(string title, DateTime startDate, DateTime endDate, string description, decimal cost, int departmentID, int managerID)
        {
            var project = new Project
            {
                Title = title,
                StartDate = startDate,
                EndDate = endDate,
                Description = description,
                Cost = cost,
                StateOfProject = "New",
                DepartmentID = departmentID,
                ManagerID = managerID

            };

            using (var ctx = new CompanyDbContext())
            {
                var newProject = ctx.Projects.Add(project);
                ctx.SaveChanges();
                return newProject;
            }
      
        }

        public void UpdateProject(int projectID, string title, DateTime startDate, DateTime endDate, string description, decimal cost, string projectState)
        {
            using (var ctx = new CompanyDbContext())
            {
                var proj = ctx.Projects.SingleOrDefault(x => x.Id.Equals(projectID));
                if (proj == null) throw new Exception("There is no project with given Id");

                proj.Title = title;
                proj.StartDate = startDate;
                proj.EndDate = endDate;
                proj.Description = description;
                proj.Cost = cost;
                proj.StateOfProject = projectState;
                ctx.SaveChanges();
            }
        }

        public void UpdateState(int projectID, string projectState)
        {
            using (var ctx = new CompanyDbContext())
            {
                var proj = ctx.Projects.SingleOrDefault(x => x.Id.Equals(projectID));
                if (proj == null) throw new Exception("There is no project with given Id");

                proj.StateOfProject = projectState;
                ctx.SaveChanges();
            }
        }

        public void UpdateProjectStateAfterCreatingTask(int projectID)
        {
            using (var ctx = ContextFactory.Create())
            {
                var proj = ctx.Projects.SingleOrDefault(x => x.Id.Equals(projectID));
                if (proj == null) throw new Exception("Project with that Id does not exist");

                proj.StateOfProject = "InProgres";
            }
        }

        public void UpdateProjectsWhenDepartmentIsCanceled(int departmentID)
        {
            using (var ctx = ContextFactory.Create())
            {
                var projects = ctx.Projects.Where(x => x.DepartmentID.Equals(departmentID)).ToList();
                projects.ForEach(x => x.StateOfProject ="Canceled");
                ctx.SaveChanges();
            }
        }

        public void deleteProject(Project project)
        {
            using (var ctx = new CompanyDbContext())
            {
                ctx.Projects.Remove(project);
                ctx.SaveChanges();
            }
        }
    }
}
