using Model;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class ProjectController : Controller
    {
        private ProjectServices _projectService;
        private DepartmentServices _departmentService = new DepartmentServices();
        public ProjectController()
        {
            _projectService = new ProjectServices();
            _departmentService = new DepartmentServices();
        }

        //------------------CREATE NEW  PROJECT------------------------------------------
        // GET: method
        [HttpGet]
        public ActionResult newProject()
        {
            return View();  //CREATE new project page
        }

        //POST: method
        [HttpPost]
        public ActionResult newProject(Project project)
        {
            var dep = _departmentService.GetDepartmentByID(project.DepartmentID);
            var newProject = _projectService.InsertProject(project.Title, project.StartDate, project.EndDate, project.Description, project.Cost, dep.Id, project.ManagerID);

            if (newProject != null)
            {
                return View("Success");
            }
            return View("Fail");
        }
    }
}