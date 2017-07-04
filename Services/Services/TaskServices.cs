using DAL;
using DAL.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class TaskServices
    {


        public List<Task> GetAllTasksForSelectedProject(int projectId)  //rename from GetTasksByEmployeeOnProject
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Tasks.Where(x => x.ProjectID.Equals(projectId)).ToList();
            }
        }

        //?????
        public List<Task> GetEmployeeTasksForSelectedProject(int employeeId, int projectId)
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Tasks.Where(x => x.ProjectID.Equals(projectId) && x.EmployeeID.Equals(employeeId)).ToList();
            }
        }

        public void InsertTask(string title, DateTime startDate, DateTime endDate, int estimated, int remainig, string description, string comment, string stateOfTask, int employeeID, int projectID)
        {
            using (var ctx = new CompanyDbContext())
            {
                var task = new Task
                {
                    Title = title,
                    StartDate = startDate,
                    EndDate = endDate,
                    EstimatedWorkingHour = estimated,
                    RemainingWorkingHour = remainig,
                    Description = description,
                    Comment = comment,
                    StateOfTask = stateOfTask,
                    EmployeeID = employeeID,
                    ProjectID = projectID
                };
                ctx.Tasks.Add(task);
                ctx.SaveChanges();
            }
        }

        public void UpdateTask(int taskID, int estimated, int remainig, string comment, string stateOfTask)     // rename from UpdateTaskByEmployee
        {
            using (var ctx = new CompanyDbContext())
            {
                var task = ctx.Tasks.SingleOrDefault(x => x.Id.Equals(taskID));
                if (task == null) throw new Exception("Task with given Id does not exist");

                task.EstimatedWorkingHour = estimated;
                task.RemainingWorkingHour = remainig;
                task.Comment = comment;
                task.StateOfTask = stateOfTask;
    
                ctx.SaveChanges();
            }
        }

        public void UpdateTaskWhenStateChangedToDone(int taskID)
        {
            using (var ctx = ContextFactory.Create())
            {
                var task = ctx.Tasks.SingleOrDefault(x => x.Id.Equals(taskID));
                if (task == null) throw new Exception("Task with that id does not exist");

                task.StateOfTask = "Done";
                ctx.SaveChanges();
            }
        }

        public void UpdateTasksWhenProjectIsCanceled(int projectID)
        {
            using (var ctx = ContextFactory.Create())
            {
                var tasks = ctx.Tasks.Where(x => x.Id.Equals(projectID)).ToList();
                tasks.ForEach(x => x.StateOfTask = "Canceled");
                ctx.SaveChanges();
            }
        }

        public void UpdateTasksWhenDepartmentIsCanceled(int departmentID)
        {
            using (var ctx = ContextFactory.Create())
            {
                var tasks = ctx.Projects.Where(x => x.Id.Equals(departmentID))
                                        .Join(ctx.Tasks, x => x.Id, t => t.ProjectID, (x, t) => t).ToList();
                //x,t => t means i will only return tasks, i will not do projection

                tasks.ForEach(x => x.StateOfTask = "Canceled");
                ctx.SaveChanges();
            }
        }

        public Task GetTaskByID(int taskID)
        {
            using (var ctx = new CompanyDbContext())
            {
                var task =  ctx.Tasks.SingleOrDefault(s => s.Id == (int)taskID);
                return task;
            }
        }

        public void deleteTask(Task task)
        {
            using (var ctx = new CompanyDbContext())
            {
                ctx.Tasks.Remove(task);
                ctx.SaveChanges();
            }
        }
    }
}
